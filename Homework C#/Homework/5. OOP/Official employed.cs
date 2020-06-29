	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace HR
	{
		internal class Official_employed: Employee
		{
	        public Official_employed(string name, string ssn, double weeklySalary) : base(name, ssn, weeklySalary)
			{
			}

			public override double getPaymentAmount(int numberOfWeeks)
			{
				return WeeklySalary * numberOfWeeks;
			}
		}
	}
