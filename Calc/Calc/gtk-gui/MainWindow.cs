
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Entry suma1;
	private global::Gtk.Entry suma2;
	private global::Gtk.Entry resul;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button buttonSuma;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.suma1 = new global::Gtk.Entry ();
		this.suma1.CanFocus = true;
		this.suma1.Name = "suma1";
		this.suma1.IsEditable = true;
		this.suma1.InvisibleChar = '•';
		this.vbox1.Add (this.suma1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.suma1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.suma2 = new global::Gtk.Entry ();
		this.suma2.CanFocus = true;
		this.suma2.Name = "suma2";
		this.suma2.IsEditable = true;
		this.suma2.InvisibleChar = '•';
		this.vbox1.Add (this.suma2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.suma2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.resul = new global::Gtk.Entry ();
		this.resul.CanFocus = true;
		this.resul.Name = "resul";
		this.resul.IsEditable = true;
		this.resul.InvisibleChar = '•';
		this.vbox1.Add (this.resul);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.resul]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonSuma = new global::Gtk.Button ();
		this.buttonSuma.CanFocus = true;
		this.buttonSuma.Name = "buttonSuma";
		this.buttonSuma.UseUnderline = true;
		this.buttonSuma.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox1.Add (this.buttonSuma);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSuma]));
		w4.PackType = ((global::Gtk.PackType)(1));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 243;
		this.DefaultHeight = 163;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
