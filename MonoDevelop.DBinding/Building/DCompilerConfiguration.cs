using MonoDevelop.Core.Serialization;
using System.Collections.Generic;
using D_Parser.Completion;
using System.Collections.ObjectModel;
using System;
using System.Xml;
using MonoDevelop.Core;
using System.Threading;
using D_Parser.Misc;

namespace MonoDevelop.D.Building
{
	/// <summary>
	/// Stores compiler commands and arguments for compiling and linking D source files.
	/// </summary>
	public class DCompilerConfiguration
	{
		public static bool ResetToDefaults (DCompilerConfiguration cfg)
		{
			return CompilerPresets.PresetLoader.TryLoadPresets (cfg);				
		}

		public readonly ParseCache ParseCache = new ParseCache ();
		public string BinPath = "";
		public string Vendor;
		public readonly List<LinkTargetConfiguration> LinkTargetConfigurations = new List<LinkTargetConfiguration> ();

		public LinkTargetConfiguration GetTargetConfiguration (DCompileTarget Target)
		{
			foreach (var t in LinkTargetConfigurations)
				if (t.TargetType == Target)
					return t;

			var newTarget = new LinkTargetConfiguration { TargetType=Target };
			LinkTargetConfigurations.Add (newTarget);
			return newTarget;
		}

		public void SetAllCompilerBuildArgs (string NewCompilerArguments, bool AffectDebugArguments)
		{
			foreach (var t in LinkTargetConfigurations)
				t.GetArguments (AffectDebugArguments).CompilerArguments = NewCompilerArguments;
		}

		/// <summary>
		/// Overrides all compiler command strings of all LinkTargetConfigurations
		/// </summary>
		public void SetAllCompilerCommands (string NewCompilerPath)
		{
			foreach (var t in LinkTargetConfigurations)
				t.Compiler = NewCompilerPath;
		}

		public void SetAllLinkerCommands (string NewLinkerPath)
		{
			foreach (var t in LinkTargetConfigurations)
				t.Linker = NewLinkerPath;
		}

		/// <summary>
		/// Updates the configuration's global parse cache
		/// </summary>
		public void UpdateParseCacheAsync ()
		{
			UpdateParseCacheAsync (ParseCache);
		}

		public static void UpdateParseCacheAsync (ParseCache Cache)
		{
			if (Cache == null || Cache.ParsedDirectories == null || Cache.ParsedDirectories.Count < 1)
				return;

			var th = new Thread (() =>
			{
				try {
					LoggingService.LogInfo ("Update parse cache ({0} directories)", Cache.ParsedDirectories.Count);

					var perfResults = Cache.Parse ();

					foreach (var perfData in perfResults) {
						LoggingService.LogInfo (
							"Parsed {0} files in \"{1}\" in {2}s (~{3}ms per file)",
							perfData.AmountFiles,
							perfData.BaseDirectory,
							Math.Round (perfData.TotalDuration, 3),
							Math.Round (perfData.FileDuration * 1000));
					}

					if (Cache.LastParseException != null)
						LoggingService.LogError("Error while updating parse cache", Cache.LastParseException);
				} catch (Exception ex) {
					LoggingService.LogError ("Error while updating parse cache", ex);
				}
			});

			th.Name = "Update parse cache thread";
			th.IsBackground = true;
			th.Start ();
		}

		public List<string> DefaultLibraries = new List<string> ();

		#region Loading & Saving
		public void CopyFrom (DCompilerConfiguration o)
		{
			Vendor = o.Vendor;
			BinPath = o.BinPath;

			ParseCache.ParsedDirectories.Clear();
			ParseCache.ParsedDirectories.AddRange(o.ParseCache.ParsedDirectories);

			DefaultLibraries.Clear();
			DefaultLibraries.AddRange(o.DefaultLibraries);

			LinkTargetConfigurations.Clear();
			foreach (var lt in o.LinkTargetConfigurations) {
				var newLt = new LinkTargetConfiguration ();
				newLt.CopyFrom (lt);
				LinkTargetConfigurations.Add (newLt);
			}
		}
		
		public void ReadFrom (System.Xml.XmlReader x)
		{
			XmlReader s = null;

			while (x.Read())
				switch (x.LocalName) {
				case "BinaryPath":
					BinPath = x.ReadString ();
					break;
				
				case "TargetConfiguration":
					s = x.ReadSubtree ();

					var t = new LinkTargetConfiguration ();
					t.LoadFrom (s);
					LinkTargetConfigurations.Add (t);

					s.Close ();
					break;

				case "DefaultLibs":
					s = x.ReadSubtree ();
						
					while (s.Read())
						if (s.LocalName == "lib")
							DefaultLibraries.Add (s.ReadString ());

					s.Close ();
					break;

				case "Includes":
					s = x.ReadSubtree ();

					var paths = new List<string> ();
					while (s.Read())
						if (s.LocalName == "Path")
							ParseCache.ParsedDirectories.Add (s.ReadString ());

					s.Close ();
					break;
				}
		}

		public void SaveTo (System.Xml.XmlWriter x)
		{
			x.WriteStartElement ("BinaryPath");
			x.WriteCData (BinPath);
			x.WriteEndElement ();
			
			foreach (var t in LinkTargetConfigurations) {
				x.WriteStartElement ("TargetConfiguration");

				t.SaveTo (x);

				x.WriteEndElement ();
			}

			x.WriteStartElement ("DefaultLibs");
			foreach (var lib in DefaultLibraries) {
				x.WriteStartElement ("lib");
				x.WriteCData (lib);
				x.WriteEndElement ();
			}
			x.WriteEndElement ();

			x.WriteStartElement ("Includes");
			foreach (var inc in ParseCache.ParsedDirectories) {
				x.WriteStartElement ("Path");
				x.WriteCData (inc);
				x.WriteEndElement ();
			}
			x.WriteEndElement ();
		}
		#endregion
	}

	public class LinkTargetConfiguration
	{
		public DCompileTarget TargetType;
		public string Compiler;
		public string Linker;

		#region Patterns
		/// <summary>
		/// Describes how each .obj/.o file shall be enumerated in the $objs linking macro
		/// </summary>
		public string ObjectFileLinkPattern = "\"{0}\"";
		/// <summary>
		/// Describes how each include path shall be enumerated in the $includes compiling macro
		/// </summary>
		public string IncludePathPattern = "-I\"{0}\"";
		#endregion

		public BuildConfiguration DebugArguments = new BuildConfiguration ();
		public BuildConfiguration ReleaseArguments = new BuildConfiguration ();

		public BuildConfiguration GetArguments (bool IsDebug)
		{
			return IsDebug ? DebugArguments : ReleaseArguments;
		}
		
		public void CopyFrom (LinkTargetConfiguration o)
		{
			TargetType = o.TargetType;
			Compiler = o.Compiler;
			Linker = o.Linker;
			
			ObjectFileLinkPattern = o.ObjectFileLinkPattern;
			IncludePathPattern = o.IncludePathPattern;
			
			DebugArguments.CopyFrom (o.DebugArguments);
			ReleaseArguments.CopyFrom (o.ReleaseArguments);
		}

		public void SaveTo (System.Xml.XmlWriter x)
		{
			x.WriteAttributeString ("Target", TargetType.ToString ());
			
			x.WriteStartElement ("CompilerCommand");
			x.WriteCData (Compiler);
			x.WriteEndElement ();

			x.WriteStartElement ("LinkerCommand");
			x.WriteCData (Linker);
			x.WriteEndElement ();

			x.WriteStartElement ("ObjectLinkPattern");
			x.WriteCData (ObjectFileLinkPattern);
			x.WriteEndElement ();

			x.WriteStartElement ("IncludePathPattern");
			x.WriteCData (IncludePathPattern);
			x.WriteEndElement ();

			x.WriteStartElement ("DebugArgs");
			DebugArguments.SaveTo (x);
			x.WriteEndElement ();

			x.WriteStartElement ("ReleaseArgs");
			ReleaseArguments.SaveTo (x);
			x.WriteEndElement ();
		}

		public void LoadFrom (System.Xml.XmlReader x)
		{
			if (x.ReadState == ReadState.Initial)
				x.Read ();

			if (x.MoveToAttribute ("Target"))
				TargetType = (DCompileTarget)Enum.Parse (typeof(DCompileTarget), x.ReadContentAsString ());

			while (x.Read())
				switch (x.LocalName) {
				case "CompilerCommand":
					Compiler = x.ReadString ();
					break;
				case "LinkerCommand":
					Linker = x.ReadString ();
					break;
				case "ObjectLinkPattern":
					ObjectFileLinkPattern = x.ReadString ();
					break;
				case "IncludePathPattern":
					IncludePathPattern = x.ReadString ();
					break;

				case "DebugArgs":
					var s = x.ReadSubtree ();
					DebugArguments.ReadFrom (s);
					s.Close ();
					break;

				case "ReleaseArgs":
					var s2 = x.ReadSubtree ();
					ReleaseArguments.ReadFrom (s2);
					s2.Close ();
					break;
				}
		}
	}

	public class BuildConfiguration
	{
		public string CompilerArguments;
		public string LinkerArguments;
		
		public void CopyFrom (BuildConfiguration o)
		{
			CompilerArguments = o.CompilerArguments;
			LinkerArguments = o.LinkerArguments;
		}
		
		public void SaveTo (System.Xml.XmlWriter x)
		{
			x.WriteStartElement ("CompilerArg");
			x.WriteCData (CompilerArguments);
			x.WriteEndElement ();

			x.WriteStartElement ("LinkerArgs");
			x.WriteCData (LinkerArguments);
			x.WriteEndElement ();
		}

		public void ReadFrom (System.Xml.XmlReader x)
		{
			while (x.Read())
				switch (x.LocalName) {
				case "CompilerArg":
					CompilerArguments = x.ReadString ();
					break;
				case "LinkerArgs":
					LinkerArguments = x.ReadString ();
					break;
				}
		}
	}
}

