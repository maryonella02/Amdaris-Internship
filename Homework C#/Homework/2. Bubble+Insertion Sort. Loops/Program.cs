using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Homework2
{
   class Program
   {
 
       static void Main(string[] args)
       {
 
           int[] number = { 20, 15, 40, 35, 60, 70, 85 };
           bool flag = true;
           int temp;
           int numLength = number.Length;
           Console.WriteLine("Bubble Sort");
           Console.Write("Initial Array is: ");
           int index1, l = 7;
           for (index1 = 0; index1 < l; index1++)
           {
               Console.Write(number[index1] + " ");
           }
 
           //sorting an array 
           for (int i = 0; (i < (numLength - 1)) && flag; i++)
           {
               flag = false;
               for (int j = 0; j < (numLength - 1); j++)
               {
                   if (number[j + 1] > number[j])
                   {
                       temp = number[j];
                       number[j] = number[j + 1];
                       number[j + 1] = temp;
                       flag = true;
                   }
               }
           }
 
           //Sorted array 
 
           Console.Write("\nSorted Array is: ");
           for (index1 = 0; index1 < l; index1++)
           {
               Console.Write(number[index1] + " ");
           }
           Console.ReadKey();
 
 
           Console.WriteLine("\r\n**************************************************************************");
           Console.ReadLine();
 
           Task1.Ex1continuare();
           Task2.Ex2();
           Task3.Ex3();
           Task4.Ex4();
 
           Console.ReadKey();
 
       }
 
 
   }
   public class Task1
   {
       public static void Ex1continuare()
       {
           int[] arr = { 38, 60, 9, 67, 57, 89, 104, 160 };
 
 
           int arrLength = arr.Length;
           int startIndex = 0;
           Console.WriteLine("Insertion Sort");
           Console.Write("Initial Array is: ");
           int i, n = 8;
           for (i = 0; i < n; i++)
           {
               Console.Write(arr[i] + " ");
           }
           while (startIndex < arrLength)
           {
               int maxIndex = startIndex;
               int ind = startIndex;
               while (ind < arrLength)
               {
                   var x = arr[ind];
                   var y = arr[maxIndex];
                   if (x > y)
                   {
                       maxIndex = ind;
                   }
                   ind++;
               }
 
               var temporary = arr[startIndex];
               arr[startIndex] = arr[maxIndex];
               arr[maxIndex] = temporary;
 
               startIndex++;
           }
 
 
           Console.Write("\nSorted Array is: ");
           for (i = 0; i < n; i++)
           {
               Console.Write(arr[i] + " ");
           }
 
           Console.ReadKey();
           Console.WriteLine("\r\n**************************************************************************");
           Console.ReadKey();
       }
   }
   public class Task2
   {
       public static void Ex2()
       {
           string s, revs = "";
           Console.WriteLine(" Scrie un cuvant");
           s = Console.ReadLine();
           for (int i = s.Length - 1; i >= 0; i--) //reversarea stringului 
           {
               revs += s[i];
           }
           if (revs == s) // verificarea daca stringul e polindrom sau nu
           {
               Console.WriteLine("Cuvantul e polindrom \nCuvantul introdus este {0} si cuvantul inversat este {1}", s, revs);
           }
           else
           {
               Console.WriteLine("Cuvantul nu e polindrom  \nCuvantul introdus este {0} si cuvantul inversat este {1}", s, revs);
           }
           Console.ReadKey();
           Console.WriteLine("\r\n**************************************************************************");
           Console.ReadKey();
       }
   }
 
   public class Task3
   {
       public static void Ex3()
       {
           string s, revs = "";
           Console.WriteLine(" Scrie un cuvant");
           s = Console.ReadLine();
           for (int i = s.Length - 1; i >= 0; i--) //reversarea stringului 
           {
               revs += s[i];
           }
 
           Console.WriteLine("Cuvantul inversat este {0}", revs);
           Console.ReadKey();
           Console.WriteLine("\r\n**************************************************************************");
 
           Console.ReadKey();
       }
   }
   public class Task4
   {
       public static void Ex4()
       {
           double paine = 5;
           double zahar = 17;
           double lapte = 12;
           int index = 0;
           bool correctChoice = false;
           double pretTotal = 0;
 
           Console.WriteLine("Lista produselor disponibile: ");
           Console.WriteLine($"1. Paine - {paine} lei");
           Console.WriteLine($"2. Zahar - {zahar} lei");
           Console.WriteLine($"3. Lapte - {lapte} lei");
           bool terminareaOperatiunii = false;
 
           while (terminareaOperatiunii == false)
           {
               Console.WriteLine("Alege numarul produsului sau apasa [x] sa anulezi comanda");
               string input = Console.ReadLine();
               if (input.ToLower() == "x")
               {
                   terminareaOperatiunii = true;
               }
               else
               {
                   correctChoice = false;
 
                   while (correctChoice == false)
                   {
 
                       index = Convert.ToInt32(input);
 
                       if (index < 4)
                       {
                           correctChoice = true;
                       }
                       else
                       {
                           Console.WriteLine("Produs inexistent");
                           Console.WriteLine("Alegeti alt produs");
                           input = Console.ReadLine();
                       }
                   }
               }
               if (terminareaOperatiunii != true)
               {
                   Console.WriteLine("Alege cantitatea");
                   int cantitate = Convert.ToInt32(Console.ReadLine());
                   double pret = 0;
                   switch (index)
                   {
                       case 1:
                           pret = 1.2 * paine * cantitate;
                           break;
                       case 2:
                           pret = 1.2 * zahar * cantitate;
                           break;
                       case 3:
                           pret = 1.2 * lapte * cantitate;
                           break;
                   }
                   pretTotal = pret + pretTotal;
               }
 
               Console.WriteLine($"Pret total: {pretTotal}");
           }
           Console.ReadKey();
       }
   }
}
 
 
 
 
 
 
 
 

