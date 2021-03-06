
// This file has been generated by the GUI designer. Do not modify.
namespace MonoReports.Gui.Widgets
{
	public partial class MainDesignView
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Notebook mainNotebook;
		private global::Gtk.ScrolledWindow designScrolledWindow;
		private global::Gtk.DrawingArea drawingarea;
		private global::Gtk.Label designTitleLabel;
		private global::Gtk.VBox previewVbox;
		private global::Gtk.ScrolledWindow previewScrolledWindow;
		private global::Gtk.DrawingArea previewDrawingArea;
		private global::Gtk.Toolbar previewToolbar;
		private global::Gtk.Label previewTitleLabel;
		private global::Gtk.VBox vbox2;
		private global::Gtk.VPaned vpaned1;
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox datasourceManageHbox;
		private global::Gtk.Label datasourceTypeLabel;
		private global::Gtk.RadioButton jsonRadiobutton;
		private global::Gtk.RadioButton csharpRadiobutton;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView codeTextview;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView outputTextview;
		private global::Gtk.Label datasourceLabel;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoReports.Gui.Widgets.MainDesignView
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "MonoReports.Gui.Widgets.MainDesignView";
			// Container child MonoReports.Gui.Widgets.MainDesignView.Gtk.Container+ContainerChild
			this.mainNotebook = new global::Gtk.Notebook ();
			this.mainNotebook.CanFocus = true;
			this.mainNotebook.Events = ((global::Gdk.EventMask)(52992));
			this.mainNotebook.Name = "mainNotebook";
			this.mainNotebook.CurrentPage = 2;
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.designScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.designScrolledWindow.CanFocus = true;
			this.designScrolledWindow.Name = "designScrolledWindow";
			this.designScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child designScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w3 = new global::Gtk.Viewport ();
			w3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.CanFocus = true;
			this.drawingarea.Events = ((global::Gdk.EventMask)(77574));
			this.drawingarea.ExtensionEvents = ((global::Gdk.ExtensionMode)(1));
			this.drawingarea.Name = "drawingarea";
			w3.Add (this.drawingarea);
			this.designScrolledWindow.Add (w3);
			this.mainNotebook.Add (this.designScrolledWindow);
			// Notebook tab
			this.designTitleLabel = new global::Gtk.Label ();
			this.designTitleLabel.Name = "designTitleLabel";
			this.designTitleLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("desing");
			this.mainNotebook.SetTabLabel (this.designScrolledWindow, this.designTitleLabel);
			this.designTitleLabel.ShowAll ();
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.previewVbox = new global::Gtk.VBox ();
			this.previewVbox.Name = "previewVbox";
			this.previewVbox.Spacing = 6;
			// Container child previewVbox.Gtk.Box+BoxChild
			this.previewScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.previewScrolledWindow.CanFocus = true;
			this.previewScrolledWindow.Name = "previewScrolledWindow";
			this.previewScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child previewScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w7 = new global::Gtk.Viewport ();
			w7.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.previewDrawingArea = new global::Gtk.DrawingArea ();
			this.previewDrawingArea.Events = ((global::Gdk.EventMask)(774));
			this.previewDrawingArea.Name = "previewDrawingArea";
			w7.Add (this.previewDrawingArea);
			this.previewScrolledWindow.Add (w7);
			this.previewVbox.Add (this.previewScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.previewVbox [this.previewScrolledWindow]));
			w10.Position = 0;
			// Container child previewVbox.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='previewToolbar'/></ui>");
			this.previewToolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/previewToolbar")));
			this.previewToolbar.Name = "previewToolbar";
			this.previewToolbar.ShowArrow = false;
			this.previewVbox.Add (this.previewToolbar);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.previewVbox [this.previewToolbar]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.mainNotebook.Add (this.previewVbox);
			global::Gtk.Notebook.NotebookChild w12 = ((global::Gtk.Notebook.NotebookChild)(this.mainNotebook [this.previewVbox]));
			w12.Position = 1;
			// Notebook tab
			this.previewTitleLabel = new global::Gtk.Label ();
			this.previewTitleLabel.Name = "previewTitleLabel";
			this.previewTitleLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("preview");
			this.mainNotebook.SetTabLabel (this.previewVbox, this.previewTitleLabel);
			this.previewTitleLabel.ShowAll ();
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 338;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.datasourceManageHbox = new global::Gtk.HBox ();
			this.datasourceManageHbox.Name = "datasourceManageHbox";
			this.datasourceManageHbox.Spacing = 6;
			// Container child datasourceManageHbox.Gtk.Box+BoxChild
			this.datasourceTypeLabel = new global::Gtk.Label ();
			this.datasourceTypeLabel.Name = "datasourceTypeLabel";
			this.datasourceTypeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Datasource:");
			this.datasourceManageHbox.Add (this.datasourceTypeLabel);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.datasourceManageHbox [this.datasourceTypeLabel]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child datasourceManageHbox.Gtk.Box+BoxChild
			this.jsonRadiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Json"));
			this.jsonRadiobutton.CanFocus = true;
			this.jsonRadiobutton.Name = "jsonRadiobutton";
			this.jsonRadiobutton.DrawIndicator = true;
			this.jsonRadiobutton.UseUnderline = true;
			this.jsonRadiobutton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.datasourceManageHbox.Add (this.jsonRadiobutton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.datasourceManageHbox [this.jsonRadiobutton]));
			w14.Position = 1;
			w14.Expand = false;
			// Container child datasourceManageHbox.Gtk.Box+BoxChild
			this.csharpRadiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("C# code"));
			this.csharpRadiobutton.CanFocus = true;
			this.csharpRadiobutton.Name = "csharpRadiobutton";
			this.csharpRadiobutton.DrawIndicator = true;
			this.csharpRadiobutton.UseUnderline = true;
			this.csharpRadiobutton.Group = this.jsonRadiobutton.Group;
			this.datasourceManageHbox.Add (this.csharpRadiobutton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.datasourceManageHbox [this.csharpRadiobutton]));
			w15.Position = 2;
			w15.Expand = false;
			this.vbox1.Add (this.datasourceManageHbox);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datasourceManageHbox]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.codeTextview = new global::Gtk.TextView ();
			this.codeTextview.CanFocus = true;
			this.codeTextview.Name = "codeTextview";
			this.GtkScrolledWindow.Add (this.codeTextview);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w18.Position = 1;
			this.vpaned1.Add (this.vbox1);
			global::Gtk.Paned.PanedChild w19 = ((global::Gtk.Paned.PanedChild)(this.vpaned1 [this.vbox1]));
			w19.Resize = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.outputTextview = new global::Gtk.TextView ();
			this.outputTextview.CanFocus = true;
			this.outputTextview.Name = "outputTextview";
			this.GtkScrolledWindow1.Add (this.outputTextview);
			this.vpaned1.Add (this.GtkScrolledWindow1);
			this.vbox2.Add (this.vpaned1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vpaned1]));
			w22.Position = 0;
			this.mainNotebook.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w23 = ((global::Gtk.Notebook.NotebookChild)(this.mainNotebook [this.vbox2]));
			w23.Position = 2;
			// Notebook tab
			this.datasourceLabel = new global::Gtk.Label ();
			this.datasourceLabel.Name = "datasourceLabel";
			this.datasourceLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("datasource");
			this.mainNotebook.SetTabLabel (this.vbox2, this.datasourceLabel);
			this.datasourceLabel.ShowAll ();
			this.Add (this.mainNotebook);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
			this.mainNotebook.SwitchPage += new global::Gtk.SwitchPageHandler (this.OnMainNotebookSwitchPage);
			this.drawingarea.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnDrawingareaButtonPressEvent);
			this.drawingarea.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnDrawingareaButtonReleaseEvent);
			this.drawingarea.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler (this.OnDrawingareaMotionNotifyEvent);
			this.drawingarea.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnDrawingareaExposeEvent);
			this.drawingarea.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnDrawingareaKeyPressEvent);
			this.drawingarea.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnDrawingareaKeyReleaseEvent);
			this.drawingarea.LeaveNotifyEvent += new global::Gtk.LeaveNotifyEventHandler (this.OnDrawingareaLeaveNotifyEvent);
			this.previewDrawingArea.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnPreviewDrawingareaExposeEvent);
			this.previewDrawingArea.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnDrawingareaButtonPressEvent);
			this.previewDrawingArea.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnDrawingareaButtonReleaseEvent);
			this.previewDrawingArea.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler (this.OnDrawingareaMotionNotifyEvent);
			this.jsonRadiobutton.Clicked += new global::System.EventHandler (this.OnJsonRadiobuttonClicked);
			this.csharpRadiobutton.Clicked += new global::System.EventHandler (this.OnCsharpRadiobuttonClicked);
		}
	}
}
