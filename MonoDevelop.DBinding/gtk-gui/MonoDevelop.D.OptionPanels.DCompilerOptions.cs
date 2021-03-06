
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.D.OptionPanels
{
	public partial class DCompilerOptions
	{
		private global::Gtk.VBox vbox8;
		private global::Gtk.Table table6;
		private global::Gtk.Button btnDefaults;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Entry txtBinPath;
		private global::Gtk.Button button_BinPathBrowser;
		private global::Gtk.HBox hbox4;
		private global::Gtk.ComboBoxEntry cmbCompilers;
		private global::Gtk.Button btnApplyRenaming;
		private global::Gtk.Button btnAddCompiler;
		private global::Gtk.Button btnRemoveCompiler;
		private global::Gtk.ToggleButton btnMakeDefault;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Button btnDebugArguments;
		private global::Gtk.Button btnReleaseArguments;
		private global::Gtk.Label label2;
		private global::Gtk.Label label28;
		private global::Gtk.Label label29;
		private global::Gtk.Label label3;
		private global::Gtk.Label label30;
		private global::Gtk.Label label31;
		private global::Gtk.Label label32;
		private global::Gtk.Entry txtCompiler;
		private global::Gtk.Entry txtConsoleAppLinker;
		private global::Gtk.Entry txtGUIAppLinker;
		private global::Gtk.Entry txtSharedLibLinker;
		private global::Gtk.Entry txtStaticLibLinker;
		private global::Gtk.Notebook notebook2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView text_DefaultLibraries;
		private global::Gtk.Label label12;
		private global::Gtk.Table table2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView text_Includes;
		private global::Gtk.Table table3;
		private global::Gtk.Button button_AddInclude;
		private global::Gtk.Label label1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.D.OptionPanels.DCompilerOptions
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.D.OptionPanels.DCompilerOptions";
			// Container child MonoDevelop.D.OptionPanels.DCompilerOptions.Gtk.Container+ContainerChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.table6 = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.table6.Name = "table6";
			this.table6.RowSpacing = ((uint)(6));
			this.table6.ColumnSpacing = ((uint)(6));
			// Container child table6.Gtk.Table+TableChild
			this.btnDefaults = new global::Gtk.Button ();
			this.btnDefaults.CanFocus = true;
			this.btnDefaults.Name = "btnDefaults";
			this.btnDefaults.UseUnderline = true;
			this.btnDefaults.Label = global::Mono.Unix.Catalog.GetString ("Defaults");
			this.table6.Add (this.btnDefaults);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table6 [this.btnDefaults]));
			w1.TopAttach = ((uint)(7));
			w1.BottomAttach = ((uint)(8));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.txtBinPath = new global::Gtk.Entry ();
			this.txtBinPath.CanFocus = true;
			this.txtBinPath.Name = "txtBinPath";
			this.txtBinPath.IsEditable = true;
			this.txtBinPath.InvisibleChar = '●';
			this.hbox2.Add (this.txtBinPath);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtBinPath]));
			w2.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button_BinPathBrowser = new global::Gtk.Button ();
			this.button_BinPathBrowser.CanFocus = true;
			this.button_BinPathBrowser.Name = "button_BinPathBrowser";
			this.button_BinPathBrowser.UseUnderline = true;
			this.button_BinPathBrowser.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.hbox2.Add (this.button_BinPathBrowser);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button_BinPathBrowser]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.table6.Add (this.hbox2);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table6 [this.hbox2]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 2;
			// Container child hbox4.Gtk.Box+BoxChild
			this.cmbCompilers = global::Gtk.ComboBoxEntry.NewText ();
			this.cmbCompilers.Name = "cmbCompilers";
			this.hbox4.Add (this.cmbCompilers);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.cmbCompilers]));
			w5.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnApplyRenaming = new global::Gtk.Button ();
			this.btnApplyRenaming.TooltipMarkup = "Press to rename current compiler configuration";
			this.btnApplyRenaming.CanFocus = true;
			this.btnApplyRenaming.Name = "btnApplyRenaming";
			this.btnApplyRenaming.UseUnderline = true;
			this.btnApplyRenaming.Label = global::Mono.Unix.Catalog.GetString ("Apply new name");
			this.hbox4.Add (this.btnApplyRenaming);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.btnApplyRenaming]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnAddCompiler = new global::Gtk.Button ();
			this.btnAddCompiler.TooltipMarkup = "Click to add an empty configuration with the name entered in the drop-down";
			this.btnAddCompiler.WidthRequest = 24;
			this.btnAddCompiler.CanFocus = true;
			this.btnAddCompiler.Name = "btnAddCompiler";
			this.btnAddCompiler.UseUnderline = true;
			// Container child btnAddCompiler.Gtk.Container+ContainerChild
			global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w8 = new global::Gtk.HBox ();
			w8.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w8.Add (w9);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w11 = new global::Gtk.Label ();
			w8.Add (w11);
			w7.Add (w8);
			this.btnAddCompiler.Add (w7);
			this.hbox4.Add (this.btnAddCompiler);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.btnAddCompiler]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnRemoveCompiler = new global::Gtk.Button ();
			this.btnRemoveCompiler.TooltipMarkup = "Remove current configuration";
			this.btnRemoveCompiler.WidthRequest = 24;
			this.btnRemoveCompiler.CanFocus = true;
			this.btnRemoveCompiler.Name = "btnRemoveCompiler";
			this.btnRemoveCompiler.UseUnderline = true;
			// Container child btnRemoveCompiler.Gtk.Container+ContainerChild
			global::Gtk.Alignment w16 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w17 = new global::Gtk.HBox ();
			w17.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w18 = new global::Gtk.Image ();
			w18.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			w17.Add (w18);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w20 = new global::Gtk.Label ();
			w17.Add (w20);
			w16.Add (w17);
			this.btnRemoveCompiler.Add (w16);
			this.hbox4.Add (this.btnRemoveCompiler);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.btnRemoveCompiler]));
			w24.Position = 3;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnMakeDefault = new global::Gtk.ToggleButton ();
			this.btnMakeDefault.TooltipMarkup = "Click to make the current configuration default";
			this.btnMakeDefault.Name = "btnMakeDefault";
			this.btnMakeDefault.UseUnderline = true;
			this.btnMakeDefault.Active = true;
			this.btnMakeDefault.Label = global::Mono.Unix.Catalog.GetString ("Make Default");
			this.hbox4.Add (this.btnMakeDefault);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.btnMakeDefault]));
			w25.Position = 4;
			w25.Expand = false;
			w25.Fill = false;
			this.table6.Add (this.hbox4);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table6 [this.hbox4]));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnDebugArguments = new global::Gtk.Button ();
			this.btnDebugArguments.CanFocus = true;
			this.btnDebugArguments.Name = "btnDebugArguments";
			this.btnDebugArguments.UseUnderline = true;
			this.btnDebugArguments.Label = global::Mono.Unix.Catalog.GetString ("Debug Arguments");
			this.hbox8.Add (this.btnDebugArguments);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnDebugArguments]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnReleaseArguments = new global::Gtk.Button ();
			this.btnReleaseArguments.CanFocus = true;
			this.btnReleaseArguments.Name = "btnReleaseArguments";
			this.btnReleaseArguments.UseUnderline = true;
			this.btnReleaseArguments.Label = global::Mono.Unix.Catalog.GetString ("Release Arguments");
			this.hbox8.Add (this.btnReleaseArguments);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnReleaseArguments]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.table6.Add (this.hbox8);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table6 [this.hbox8]));
			w29.TopAttach = ((uint)(7));
			w29.BottomAttach = ((uint)(8));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Toolchain bin path");
			this.table6.Add (this.label2);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table6 [this.label2]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label28 = new global::Gtk.Label ();
			this.label28.Name = "label28";
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString ("Static lib linker");
			this.table6.Add (this.label28);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table6 [this.label28]));
			w31.TopAttach = ((uint)(6));
			w31.BottomAttach = ((uint)(7));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label29 = new global::Gtk.Label ();
			this.label29.Name = "label29";
			this.label29.LabelProp = global::Mono.Unix.Catalog.GetString ("Shared lib linker");
			this.table6.Add (this.label29);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table6 [this.label29]));
			w32.TopAttach = ((uint)(5));
			w32.BottomAttach = ((uint)(6));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiler");
			this.table6.Add (this.label3);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table6 [this.label3]));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label30 = new global::Gtk.Label ();
			this.label30.Name = "label30";
			this.label30.LabelProp = global::Mono.Unix.Catalog.GetString ("Console app linker");
			this.table6.Add (this.label30);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table6 [this.label30]));
			w34.TopAttach = ((uint)(4));
			w34.BottomAttach = ((uint)(5));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label31 = new global::Gtk.Label ();
			this.label31.Name = "label31";
			this.label31.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiler executable");
			this.table6.Add (this.label31);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table6 [this.label31]));
			w35.TopAttach = ((uint)(2));
			w35.BottomAttach = ((uint)(3));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label32 = new global::Gtk.Label ();
			this.label32.Name = "label32";
			this.label32.LabelProp = global::Mono.Unix.Catalog.GetString ("GUI app linker");
			this.table6.Add (this.label32);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table6 [this.label32]));
			w36.TopAttach = ((uint)(3));
			w36.BottomAttach = ((uint)(4));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtCompiler = new global::Gtk.Entry ();
			this.txtCompiler.CanFocus = true;
			this.txtCompiler.Name = "txtCompiler";
			this.txtCompiler.IsEditable = true;
			this.txtCompiler.InvisibleChar = '•';
			this.table6.Add (this.txtCompiler);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtCompiler]));
			w37.TopAttach = ((uint)(2));
			w37.BottomAttach = ((uint)(3));
			w37.LeftAttach = ((uint)(1));
			w37.RightAttach = ((uint)(2));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtConsoleAppLinker = new global::Gtk.Entry ();
			this.txtConsoleAppLinker.CanFocus = true;
			this.txtConsoleAppLinker.Name = "txtConsoleAppLinker";
			this.txtConsoleAppLinker.IsEditable = true;
			this.txtConsoleAppLinker.InvisibleChar = '•';
			this.table6.Add (this.txtConsoleAppLinker);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtConsoleAppLinker]));
			w38.TopAttach = ((uint)(4));
			w38.BottomAttach = ((uint)(5));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtGUIAppLinker = new global::Gtk.Entry ();
			this.txtGUIAppLinker.CanFocus = true;
			this.txtGUIAppLinker.Name = "txtGUIAppLinker";
			this.txtGUIAppLinker.IsEditable = true;
			this.txtGUIAppLinker.InvisibleChar = '•';
			this.table6.Add (this.txtGUIAppLinker);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtGUIAppLinker]));
			w39.TopAttach = ((uint)(3));
			w39.BottomAttach = ((uint)(4));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtSharedLibLinker = new global::Gtk.Entry ();
			this.txtSharedLibLinker.CanFocus = true;
			this.txtSharedLibLinker.Name = "txtSharedLibLinker";
			this.txtSharedLibLinker.IsEditable = true;
			this.txtSharedLibLinker.InvisibleChar = '•';
			this.table6.Add (this.txtSharedLibLinker);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtSharedLibLinker]));
			w40.TopAttach = ((uint)(5));
			w40.BottomAttach = ((uint)(6));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.txtStaticLibLinker = new global::Gtk.Entry ();
			this.txtStaticLibLinker.CanFocus = true;
			this.txtStaticLibLinker.Name = "txtStaticLibLinker";
			this.txtStaticLibLinker.IsEditable = true;
			this.txtStaticLibLinker.InvisibleChar = '•';
			this.table6.Add (this.txtStaticLibLinker);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table6 [this.txtStaticLibLinker]));
			w41.TopAttach = ((uint)(6));
			w41.BottomAttach = ((uint)(7));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox8.Add (this.table6);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.table6]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.notebook2 = new global::Gtk.Notebook ();
			this.notebook2.CanFocus = true;
			this.notebook2.Name = "notebook2";
			this.notebook2.CurrentPage = 1;
			this.notebook2.ShowBorder = false;
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.text_DefaultLibraries = new global::Gtk.TextView ();
			this.text_DefaultLibraries.TooltipMarkup = "A line-separated list of library references to link in by default";
			this.text_DefaultLibraries.HeightRequest = 80;
			this.text_DefaultLibraries.CanFocus = true;
			this.text_DefaultLibraries.Name = "text_DefaultLibraries";
			this.GtkScrolledWindow.Add (this.text_DefaultLibraries);
			this.notebook2.Add (this.GtkScrolledWindow);
			// Notebook tab
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Default Libraries");
			this.notebook2.SetTabLabel (this.GtkScrolledWindow, this.label12);
			this.label12.ShowAll ();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.TooltipMarkup = "Line-separated list of paths where the compiler (and the code completion engine!)" +
				" shall look in to resolve imports.";
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.text_Includes = new global::Gtk.TextView ();
			this.text_Includes.CanFocus = true;
			this.text_Includes.Name = "text_Includes";
			this.GtkScrolledWindow1.Add (this.text_Includes);
			this.table2.Add (this.GtkScrolledWindow1);
			// Container child table2.Gtk.Table+TableChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.button_AddInclude = new global::Gtk.Button ();
			this.button_AddInclude.CanFocus = true;
			this.button_AddInclude.Name = "button_AddInclude";
			this.button_AddInclude.UseUnderline = true;
			this.button_AddInclude.Label = global::Mono.Unix.Catalog.GetString ("Browse & Add");
			this.table3.Add (this.button_AddInclude);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table3 [this.button_AddInclude]));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table2.Add (this.table3);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table2 [this.table3]));
			w48.LeftAttach = ((uint)(1));
			w48.RightAttach = ((uint)(2));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook2.Add (this.table2);
			global::Gtk.Notebook.NotebookChild w49 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2 [this.table2]));
			w49.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Includes");
			this.notebook2.SetTabLabel (this.table2, this.label1);
			this.label1.ShowAll ();
			this.vbox8.Add (this.notebook2);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.notebook2]));
			w50.Position = 1;
			this.Add (this.vbox8);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.btnDebugArguments.Clicked += new global::System.EventHandler (this.btnDebugArguments_Clicked);
			this.btnReleaseArguments.Clicked += new global::System.EventHandler (this.btnReleaseArguments_Clicked);
			this.cmbCompilers.Changed += new global::System.EventHandler (this.OnCmbCompilersChanged);
			this.btnApplyRenaming.Pressed += new global::System.EventHandler (this.OnBtnApplyRenamingPressed);
			this.btnAddCompiler.Clicked += new global::System.EventHandler (this.OnBtnAddCompilerClicked);
			this.btnRemoveCompiler.Clicked += new global::System.EventHandler (this.OnBtnRemoveCompilerClicked);
			this.btnMakeDefault.Released += new global::System.EventHandler (this.OnTogglebuttonMakeDefaultPressed);
			this.button_BinPathBrowser.Clicked += new global::System.EventHandler (this.OnButtonBinPathBrowserClicked);
			this.btnDefaults.Clicked += new global::System.EventHandler (this.OnBtnDefaultsClicked);
			this.button_AddInclude.Clicked += new global::System.EventHandler (this.OnButtonAddIncludeClicked);
		}
	}
}
