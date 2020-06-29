using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
  class Program
  {
    static void Main(string[] args)
    {
      
      var PhoneBooth1= new Phone_booth(111, "Nemo", 78);
      var HomePhone1= new HomePhone(8999, "Michael", "Picadilli");
      
      var Android1= new Android(089143241, "Ana", 8, "I89", "6866", 4 , "8.00");
      var IPhone1= new IPhone(78949, "Marin", 6846846, "X", "574586",6 , "9.00");

      Console.WriteLine("Some Results of homephone methods: ");
      HomePhone1.ReceiveCall(8999);
      HomePhone1.ReceiveCall("Michael");
      HomePhone1.Redial();
      HomePhone1.InitiateCall(8999);
      HomePhone1.CallingLineIdentification();

      Console.WriteLine("Some Results of phonebooth methods: ");
      PhoneBooth1.ReceiveCall("Nemo");
      PhoneBooth1.InitiateCall(111);
      PhoneBooth1.EmergencyCall();
      PhoneBooth1.CalculatePrice();

      Console.WriteLine("Some Results of Android methods: ");
      Android1.RecordCall();
      Android1.InstallApp();

      IPhone1. RecordCall();
      IPhone1.InstallApp();
      
      var listOfTelephones= new List<Telephone>(){PhoneBooth1, HomePhone1, IPhone1, Android1};
       foreach (Telephone t in listOfTelephones){ 
       Console.WriteLine(t);
}
       Android1.CallingLineIdentification();
    
       
      Console.ReadKey();


    }
  }
}
