using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		buttonSuma.Clicked += delegate{
			int r = int.Parse(suma1.Text) + int.Parse(suma2.Text);
			resul.Text=r.ToString();
		};
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
