using System;

namespace Calc.View {
	class Ppal {
		public static void Main(string[] args)
		{
			Gtk.Application.Init();
			var win = new MainWindow();
			win.ShowAll();
			Gtk.Application.Run();
		}
	}
}
