using System;

namespace Calc.Core {
	/// <summary>
	/// This is the facade class, created to
	/// minimize the relations between the view and the bussiness logic.
	/// </summary>
	public static class Calculator {
		public static double Add(double op1, double op2) {
			return new OperationAdd( op1, op2 ).DoIt();
		}

		public static double Minus(double op1, double op2) {
			return new OperationMinus( op1, op2 ).DoIt();
		}

		public static double Product(double op1, double op2) {
			return new OperationMultiplyBy( op1, op2 ).DoIt();
		}

		public static double Division(double op1, double op2) {
			return new OperationDivideBy( op1, op2 ).DoIt();
		}
	}
}

