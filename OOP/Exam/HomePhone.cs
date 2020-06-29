using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
  
    public class HomePhone : Telephone, ICallable

    {
      public HomePhone(int number, string designer, string address): base(number, designer)
      {
        Address = address;
      }

      public string Address { get; set; }
      public string CallingLineIdentification()
    {  Console.WriteLine("This method was implemented identification");
      return "anothersomwthing";

    }
      public void Redial()
    {
      Console.WriteLine("don't know what is redial");
    }
    }
  
}
