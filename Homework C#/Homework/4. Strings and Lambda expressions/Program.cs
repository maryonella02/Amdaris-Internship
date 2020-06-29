using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Escape Sequences:");
            /*
Definition - What does Escape Sequence mean?
In C#, an escape sequence refers to a combination of characters beginning with a back slash (\) followed by letters or digits. 
Escape sequences represent non-printable and special characters in character and literal strings. 
As such, they allow users to communicate with a display device or printer by sending non-graphical control characters to specify actions like question marks and carriage returns. */

            /* \' - single quote, needed for character literals
            \" - double quote, needed for string literals
            \\ - backslash
            \0 - Unicode character 0
            \a - Alert (character 7)
            \b - Backspace (character 8)
            \f - Form feed (character 12)
            \n - New line (character 10)
            \r - Carriage return (character 13)
            \t - Horizontal tab (character 9)
            \v - Vertical quote (character 11)
            \uxxxx - Unicode escape sequence for character with hex value xxxx
            \xn[n][n][n] - Unicode escape sequence for character with hex value nnnn (variable length version of \uxxxx)
            \Uxxxxxxxx - Unicode escape sequence for character with hex value xxxxxxxx (for generating surrogates)*/

            Console.WriteLine("CRLF:\r\nPost CRLF");
            Console.WriteLine("\tUraaa");
            Console.WriteLine("\\Uraaa");
            Console.WriteLine("\"Titanic\"");
            Console.WriteLine();

            // Basically the @ symbol tells the string constructor to ignore escape characters and line breaks.
            Console.WriteLine("2. Verbatim string:");
            string directory = @"C:\Users\marinela.branzeanu\source\repos\ConsoleApp1\ConsoleApp1";
            Console.WriteLine(directory);
            Console.WriteLine();

            //String literal. This is constant string data. We can use any type of characters within double quotes except some special character like a backslash (\).
            Console.WriteLine("3. Creating a string from a literal:");
            const string literalString = "never \\ever";
            Console.WriteLine(literalString);

            Console.WriteLine();

            //String.Concat. With concat, strings are merged (combined). It is possible to concatenate 2 or more strings with several syntax forms.
            Console.WriteLine("4. Creating a string using concatenation:");
            string s1 = "New Year!";
            string s2 = ("Happy ");
            Console.WriteLine(s2 + s1);
            Console.WriteLine();

            //
            Console.WriteLine("5. Creating a string using a constructor:");
            // Create a string from a character array.
            char[] chars = { 'd', 'o', 'n', 'n', 'u', 't' ,'"'};
            string food = new string(chars);
            Console.WriteLine(food);

            // Create a string that consists of  
            // a character repeated 20 times. 
            string sos = new string('s', 10);
            Console.WriteLine(sos);
            Console.WriteLine();

            Console.WriteLine("6. Creating a string using a property or method:");
          
            string pre = "Nothing New In The City";
            Console.WriteLine("Before: " + pre);
            Console.WriteLine("After: "  + pre.ToLower());
            Console.WriteLine();
            //string pr= " No thing New In The Ci ty ";
            
            //string newv = pr.Trim();
            //Console.WriteLine(newv);



            Console.WriteLine("7. Create a string using formatting:");
            double pret = 17;
            string produs = "Paine";
            string prezentare = string.Format("{0}a e {1} lei", produs, pret);
            Console.WriteLine(prezentare);
            Console.WriteLine();

            Console.WriteLine("8. Applying String.Replace() method:");
            var net = "dognet";
            Console.WriteLine("Before: dognet, after: {0}", net.Replace('g', 't'));
            Console.WriteLine();

            Console.WriteLine("9. Applying String.Length property:");
            string verify = "development";
            Console.WriteLine("The length of word development is {0}", verify.Length);
            Console.WriteLine();

           Console.WriteLine("10. Applying Lambda Expression with LINQ for collections from previous homework:");
            /*These expressions are expressed by the following syntax −

             (Input parameters) ⇒ Expression or statement block*/

            List<int> codProdus = new List<int>();
            codProdus.Add(453);
            codProdus.Add(466);
            codProdus.Add(476);
            codProdus.Add(486);
           
            double res = codProdus.Where(m => m % 2 == 0).First();
            Console.WriteLine("Primul cod par este "+ res);
            Console.ReadKey();
}
}
}
