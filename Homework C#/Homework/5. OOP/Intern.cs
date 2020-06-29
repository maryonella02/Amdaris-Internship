using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{

    internal class InternEmployee : Employee
    {
        public InternEmployee(string name, string ssn, double weeklySalary) : base(name, ssn, weeklySalary)
        {
        }

        public override void CallEmployee(string name)
        {
            System.Console.WriteLine("Hey bro i'm just intern by name " + name);
        }

        public override void CallEmployee(int id)
        {
       if( id < 0){
                throw new ArgumentException("ID MUST BE POSITIVE");
            }
            System.Console.WriteLine("Hey bro i'm just intern by id " + id);
        }

        public override void CallEmployee()
        {
            System.Console.WriteLine("Hey bro i'm just intern and my name is " + Name);
        }
    
        public override double getPaymentAmount(int numberOfWeeks)
        { Console.WriteLine("I have no salary :(");
            return 0 * numberOfWeeks;
        }
    }
}
    
