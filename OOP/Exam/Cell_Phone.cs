using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
 abstract public class Cell_Phone: Telephone, ICallable
  {
    public Cell_Phone(int number, string designer, int imei, string modelNumber, string cpu, byte ram): base(number, designer)
     
    {
    
      Imei = imei;
      ModelNumber = modelNumber;
      Cpu = cpu;
      Ram = ram;

    }
    private int Imei { get; set; }
    public string ModelNumber { get; set; }
    public string Cpu { get; set; }
    public byte Ram { get; set; }
    public string CallingLineIdentification()
    { Console.WriteLine("This method was implemented identification from cell phone");
      return "Something";
    }
    public abstract bool SendSMS();
    public abstract void RecordCall();
    public abstract List<int> ViewContacts();
    
  }
}
