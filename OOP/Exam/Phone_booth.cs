using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
  public class Phone_booth : Telephone

  {
    public Phone_booth(int number, string designer, byte pricePerMinute): base(number, designer)
    {
      PricePerMinute = pricePerMinute;
    }

    public byte PricePerMinute { get; set; }
    public void EmergencyCall()
    {
      Console.WriteLine("Call 112");
    }
    public int CalculatePrice()
    { Console.WriteLine("This method was implemented");
      return 4 * 78905 - 49865;
    }
  }
}
