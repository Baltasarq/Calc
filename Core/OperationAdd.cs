using System;

namespace Calc.Core {
	public class OperationAdd: Operation {
		public OperationAdd(double op1, double op2)
			:base( op1, op2 )
		{
		}

		public override double DoIt() {
			return this.Op1 + this.Op2;
		}
	}
}
