using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
 public class Android: Cell_Phone

  {
    public Android(int number, string designer, int imei, string modelNumber, string cpu, byte ram,string androidVersion): base(number, designer, imei, modelNumber, cpu, ram)
    {
      AndroidVersion = androidVersion;
    }
    public string AndroidVersion { get; set; }
    public override bool SendSMS()
    {
      return true;
    }
    public override void RecordCall()
    {
      Console.WriteLine("Record this android call");
    }
    public override List<int> ViewContacts()
    { 
      return new List<int> { 2, 5, 7 };
      
   
    }

    public void InstallApp()
    
      {
        Console.WriteLine("fhdhfg");
      }
    
  }
}
