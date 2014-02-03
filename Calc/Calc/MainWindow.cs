using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		buttonSuma.Clicked += delegate{
			decimal r = decimal.Parse(suma1.Text) + decimal.Parse(suma2.Text);
			resul.Text=r.ToString();
		};
		buttonRestar.Clicked += delegate{
			decimal r = decimal.Parse(suma1.Text) - decimal.Parse(suma2.Text);
			resul.Text=r.ToString();
		};
		buttonProducto.Clicked += delegate{
			decimal r = decimal.Parse(suma1.Text) * decimal.Parse(suma2.Text);
			resul.Text=r.ToString();
		};
		buttonDividir.Clicked += delegate{
			decimal r = decimal.Parse(suma1.Text) / decimal.Parse(suma2.Text);
			resul.Text=r.ToString();
		};
		buttonClean.Clicked += delegate{
			suma1.Text="";
			suma2.Text="";
			resul.Text="";

		};
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
