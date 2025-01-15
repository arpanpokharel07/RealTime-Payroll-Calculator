using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTIme_Payroll_Calculator
{
	public class TaxBracket
	{
		public double taxRate;
		public int from;
		public int to;

		public TaxBracket(double taxRate, int from, int to)
		{
			this.taxRate = taxRate;
			this.from = from;
			this.to = to;
		}
	}
}
