using System;

namespace Calc.Core {
	public class OperationDivideBy: Operation {
		public OperationDivideBy(double op1, double op2)
			:base( op1, op2 )
		{
		}

		public override double DoIt() {
			if ( this.Op2 == 0.0 ) {
				throw new ArithmeticException( "divider cannot be zero" );
			}

			return this.Op1 / this.Op2;
		}
	}
}
