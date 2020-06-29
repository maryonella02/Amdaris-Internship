using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
  abstract public class Telephone
  {
    public Telephone(int number, string designer)
    {
      Number = number;
      Designer = designer;
    }
    private int Number { get; set; }
    public string Designer { get; set; }
    public virtual void ReceiveCall( int number)
    {
      Console.WriteLine("Receive Call from "+number);
    }
    public virtual void ReceiveCall(string designer)
    {
      Console.WriteLine("Receive Call from " + designer);
    }
    public virtual void InitiateCall(int number)
    {
      Console.WriteLine("Initiate Call to "+ number);
    }
    public virtual void InitiateCall(string designer)
    {
      Console.WriteLine("Initiate Call to " + designer);
    }
    public override string ToString(){
return "your number is: "+Number+" "+Designer;
  }
    
}}
