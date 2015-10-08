using System;

namespace Calc.View {
	class Ppal {
		public static void Main(string[] args)
		{
			Gtk.Application.Init();
			MainWindow win = new MainWindow();
			win.ShowAll();
			Gtk.Application.Run();
		}
	}
}
