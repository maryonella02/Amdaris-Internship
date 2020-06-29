using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    abstract class Employee : IPayable
    {
        public Employee(string name, string ssn, double weeklySalary)
        {
            Name = name;
            SocialSecurityNumber = ssn;
            WeeklySalary = weeklySalary;
            BadgeId = 100;

        }
        public string Name { get; set; }

        public int BadgeId { get; set; }

        public string SocialSecurityNumber { get; set; }

        protected double WeeklySalary { get; set; }


        public virtual void CallEmployee(string name)
        {
            System.Console.WriteLine("Calling employee by name " + name);
        }

        public virtual void CallEmployee(int id)
        {
            System.Console.WriteLine("Calling employee by name " + id);
        }

        public virtual void CallEmployee()
        {
            System.Console.WriteLine("Calling employee by own name " + Name);
        }
        public override string ToString()
        {
            return "My name is : " + Name;
        }

        public abstract double getPaymentAmount(int numberOfWeeks);

        public static void PrintSalary(Employee[] employees)
        {
            foreach (Employee e in employees)
            {  e.CallEmployee();
               Console.WriteLine(e.getPaymentAmount(2));
               
            }
        }

    }
}


