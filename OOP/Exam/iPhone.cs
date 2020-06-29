using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
  public class IPhone : Cell_Phone
  {
    public IPhone(int number, string designer, int imei, string modelNumber, string cpu, byte ram, string iOSVersion) : base(number, designer, imei, modelNumber, cpu, ram)
    {
      IOSVersion = iOSVersion;
    }
    public string IOSVersion { get; set; }
    public override bool SendSMS()
    {
      return true;
    }
    public override void RecordCall()
    {
      Console.WriteLine("Record this iphone call");
    }
    public override List<int> ViewContacts()
    {
      return new List<int> { 4, 6, 8 };
    }
    
    
    public void InstallApp()
    {
      Console.WriteLine("executed");
    }
  }
}
