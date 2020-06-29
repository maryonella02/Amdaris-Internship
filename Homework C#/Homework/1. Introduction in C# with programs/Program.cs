using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Homework1
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Introduceti varsta dumneavoastra!");
           var ageString = Console.ReadLine();
           int age;
           var canParse = false;
           while (canParse == false)
           {
               canParse = int.TryParse(ageString, out age);
               if (canParse)
               {
                   if (age <= 0)
                   {
                       Console.WriteLine("Asa varsta nu exista!");
                        canParse = false;
                        ageString = Console.ReadLine();
                    }
                   else if (age < 14 || age > 65)
                   {
                       Console.WriteLine("Sunteti neangajat");
                   }
                   else if (age >= 14 || age < 18)
                   {
                       Console.WriteLine("Sunteti angajat part-time");
                   }
                   else if (age >= 18 || age <= 65)
                   {
                       Console.WriteLine("Sunteti angajat full-time");
                   }
 
 
               }
               else
               {
                   Console.WriteLine("Scrieti numar");
                   ageString = Console.ReadLine();
               }
           }
 
           Console.ReadKey();
 
           Console.WriteLine("**********************************");
 
 
 
           Console.WriteLine("Introduceti latura patratului!");
           var laturaString = Console.ReadLine();
           double latura;
           var caanParse = false;
           while (caanParse == false)
           {
 
               caanParse = double.TryParse(laturaString, out latura);
 
               if (!caanParse)
               {
                   Console.WriteLine("Nu ati introdus numar!");
                   Console.WriteLine("Introduceti latura patratului!");
                   laturaString = Console.ReadLine();
 
               }
 
               else
               {
                   var canParse2 = false;
                   while (canParse2 == false)
                   {
                       Console.WriteLine("Introduceti raza cercului!");
                       var rString = Console.ReadLine();
                       double r;
                       canParse2 = double.TryParse(rString, out r);
 
                       if (canParse2)
                       {
                           Console.WriteLine("Raspuns acceptat");
                           var perimetru = 2 * Math.PI * r;
                           var aria = Math.PI * r * r;
                           double diagonala = latura * (Math.Sqrt(2));
                           var raza = diagonala / 2;
                           Console.WriteLine("Perimetru- " + perimetru);
                           Console.WriteLine("Aria- " + aria);
                           if (r == raza)
                           {
                               Console.WriteLine("Raza= " + raza);
                           }
                           else
                               Console.WriteLine("Nu poate fi inscris");
                       }
 
                       else
                       {
                           Console.WriteLine("Nu ati introdus numar!");
                       }
                   }
               }
           }
 
           Console.ReadKey();
 
           Console.WriteLine("**********************************");
 
 
           double paine = 5;
           double zahar = 17;
           double lapte = 12;
           int index = 0;
           bool correctChoice = false;
           Console.WriteLine("Lista produselor disponibile: ");
           Console.WriteLine($"1. Paine - {paine} lei");
           Console.WriteLine($"2. Zahar - {zahar} lei");
           Console.WriteLine($"3. Lapte - {lapte} lei");
 
           while (correctChoice == false)
           {
               Console.WriteLine("Alege numarul produsului");
               index = Convert.ToInt32(Console.ReadLine());
 
               if (index < 4)
               {
                   correctChoice = true;
               }
               else
               {
                   Console.WriteLine("Produs inexistent");
               }
           }
           Console.WriteLine("Alege cantitatea");
           int cantitate = Convert.ToInt32(Console.ReadLine());
           double total = 0;
           switch (index)
           {
               case 1:
                   total = 1.2 * paine * cantitate;
                   break;
               case 2:
                   total = 1.2 * zahar * cantitate;
                   break;
               case 3:
                   total = 1.2 * lapte * cantitate;
                   break;
           }
           Console.WriteLine($"Pret total: {total}");
           Console.ReadKey();
 
           Console.WriteLine("**********************************");
 
           int numar;
           bool alesNumar = false;
           var isNumar = false;
           while (alesNumar == false)
           {
               Console.WriteLine("Introduceti numarul dorit");
               var numarString = Console.ReadLine();
               isNumar = int.TryParse(numarString, out numar);
               if (isNumar)
               {
                   alesNumar = true;
                   if (numar >= 0)
                   {
                       Console.WriteLine("Numarul este pozitiv");
                   }
                   else
                   {
                       Console.WriteLine("Numarul este negativ");
                   }
 
                   if (numar % 2 == 0)
                   {
                       Console.WriteLine("Numarul este par");
                   }
                   else
                   {
                       Console.WriteLine("Numarul este impar");
                   }
 
                   int i, m = 0, flag = 0;
                   m = numar / 2;
                   for (i = 2; i <= m; i++)
                   {
                       if (numar % i == 0)
                       {
                           Console.WriteLine("Numarul nu este prim");
                           flag = 1;
                           break;
                       }
                   }


                   if (flag == 0)
                       Console.WriteLine("Numarul este prim");
                   if (numar % 5 == 0)
                   {
                       Console.WriteLine("Numarul este multiplu al lui 5");
                   }
                   else
                   {
                       Console.WriteLine("Numarul nu este multiplu al lui 5");
                   }
 
 
                   double result = Math.Sqrt(numar);
                   bool isSquare = result % 1 == 0;

                   if (isSquare == true)
                   {
 
                       Console.WriteLine("Numarul este patrat perfect");
                       
 
                   }
                   else
                   {
                       Console.WriteLine("Numarul nu este patrat perfect");
                   }
 
 
 
                   Console.ReadLine();
               }
               else
               {
                   Console.WriteLine("Nu ati introdus numar");
               }
           }
 
       }
   }
}

