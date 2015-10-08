using System;

namespace Calc.Core {
	/// <summary>
	/// Represents arithmetic operations.
	/// 
	/// Please note that this is an exaggeration: noboyd would implement it.
	/// This is just done for the sake of showing the simpler example.
	/// </summary>
	public abstract class Operation {
		public Operation(double op1, double op2)
		{
			this.Op1 = op1;
			this.Op2 = op2;
		}

		public double Op1 {
			get; set;
		}

		public double Op2 {
			get; set;
		}

		/// <summary>
		/// Does the operation, given both parameters.
		/// </summary>
		/// <returns>The it.</returns>
		public abstract double DoIt();
	}
}

