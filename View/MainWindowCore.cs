using System;
using Calc.Core;

namespace Calc.View {
	public partial class MainWindow {
		private void OnClose() {
			Gtk.Application.Quit();
		}

		private void OnOperandsChanged() {
			double op1;
			double op2;
			double res = 0.0;

			try {
				op1 = Convert.ToDouble( this.edOp1.Text );
				op2 = Convert.ToDouble( this.edOp2.Text );

				switch( this.cbOp.ActiveText[ 0 ] ) {
				case '+':
					res = Calculator.Add( op1, op2 );
					break;
				case '-':
					res = Calculator.Minus( op1, op2 );
					break;
				case '*':
					res = Calculator.Product( op1, op2 );
					break;
				case '/':
					res = Calculator.Division( op1, op2 );
					break;
				}

				this.edRes.Text = Convert.ToString( res );
			}
			catch(FormatException) {
				this.edRes.Text = "0";
			}
			catch(ArithmeticException) {
				this.edRes.Text = "0";
			}
		}
	}
}

