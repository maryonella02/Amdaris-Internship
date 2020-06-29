using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            Official_employed employee = new Official_employed("Nichita", "356", 345);
            var salaryEd = new Official_employed("Maria", "34556767", 100);
            var intershiperEd = new InternEmployee("Nemo", "8888", 5678);
      
          try{
                intershiperEd.CallEmployee(-500);
            }
             catch(ArgumentException m){
              Console.WriteLine("Id out of range");
               Console.WriteLine(m.Message);
            }                                  catch(Exception e){
                Console.WriteLine("ID ESTE GRESIT");
                Console.WriteLine(e.Message);
            }
                                             
      
            finally{
                // nothing to do 
            } 

               var listOfEmployees = new Employee[] { salaryEd, intershiperEd, employee };
               var internSalary = new Employee[]{ intershiperEd};

            Employee.PrintSalary(listOfEmployees);
           Console.WriteLine();

            Employee.PrintSalary(internSalary);
     
        Console.ReadKey();
        }
    }
}                   