﻿using System;
using System.Collections.Generic;
using System.IO;
using MonoDevelop.Core.Serialization;
using MonoDevelop.D.Building;
using MonoDevelop.Projects;

namespace MonoDevelop.D
{
	public class DProjectConfiguration:ProjectConfiguration
	{
		#region Properties
		public DProject Project {
			get;
			protected set;
		}

		[ItemProperty("Target")]
		public DCompileTarget CompileTarget = DCompileTarget.Executable;
		[ItemProperty("OutputName")]
		public string Output = "";
		[ItemProperty("ExtraCompilerArguments", DefaultValue = "")]
		public string ExtraCompilerArguments = "";
		[ItemProperty("ExtraLinkerArguments", DefaultValue = "")]
		public string ExtraLinkerArguments = "";
		[ItemProperty("Libs")]
		[ItemProperty("Lib", Scope = "*")]
		public List<string> ExtraLibraries = new List<string> ();
		[ItemProperty("ObjectsDirectory", DefaultValue="obj")]
		public string ObjectDirectory = "obj";

		/// <summary>
		/// Returns all libs that are included by default both by the compiler and this specific build config
 		/// </summary>
		public IEnumerable<string> ReferencedLibraries
		{
			get
			{
				foreach (var i in Project.Compiler.DefaultLibraries)
					yield return i;
				foreach (var i in ExtraLibraries)
					yield return i;

				foreach (var dep in Project.DependingProjects)
				{
					var selector= dep.ParentSolution.DefaultConfigurationSelector;

					var activeConfig = dep.GetConfiguration(selector) as DProjectConfiguration;

					if (activeConfig != null && activeConfig.CompileTarget == DCompileTarget.StaticLibrary)
						yield return dep.GetOutputFileName(selector);
				}
			}
		}
		#endregion

		//if absent an exception occurs when opening project config	
		public DProjectConfiguration ()
		{
		}
		
		public DProjectConfiguration (DProject Project)
		{
			this.Project = Project;
		}

		public event EventHandler Changed;
		
		public override void CopyFrom (ItemConfiguration configuration)
		{
			base.CopyFrom (configuration);
			var conf = configuration as DProjectConfiguration;

			if (conf == null)
				return;

			ObjectDirectory = conf.ObjectDirectory;
			Output = conf.Output;
			ExtraCompilerArguments = conf.ExtraCompilerArguments;
			ExtraLinkerArguments = conf.ExtraLinkerArguments;
			CompileTarget = conf.CompileTarget;

            ExtraLibraries.Clear();
            ExtraLibraries.AddRange(conf.ExtraLibraries);
			
			if (Changed != null)
				Changed (this, new EventArgs ());
		}

		/// <summary>
		/// TODO: Ensure correctness of the extensions!
		/// </summary>
		public string CompiledOutputName {
			get {
				if (Project != null) {
					var ext = "";
						
					switch (CompileTarget) {
					case DCompileTarget.SharedLibrary:
						ext = DCompilerService.SharedLibraryExtension;
						break;
					case DCompileTarget.StaticLibrary:
						ext = DCompilerService.StaticLibraryExtension;
						break;
					default:
						ext = DCompilerService.ExecutableExtension;
						break;
					}
	
					return Path.ChangeExtension (ProjectBuilder.EnsureCorrectPathSeparators (Output), ext);
				}
				return ProjectBuilder.EnsureCorrectPathSeparators (Output);
			}
		}
	}
}
