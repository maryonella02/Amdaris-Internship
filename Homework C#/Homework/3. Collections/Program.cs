using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Nemo");
            dict.Add(2, "Nautilus");
            dict.Add(3, "Tiron");
            dict.Add(4, "One");
            dict.Add(5, "Two");
            dict.Add(6, "Three");

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
               
            }
            Console.WriteLine();

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        dict.Keys.ElementAt(i),
                                                        dict[dict.Keys.ElementAt(i)]);
            }
            Console.WriteLine();

            Console.WriteLine(dict[6]);
            Console.WriteLine();

            string result = "";
            if (dict.TryGetValue(3, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }
            Console.WriteLine();

            dict.Remove(1);
            if (dict.ContainsKey(1))
            {
                Console.WriteLine("Este prezent elementul cu cheia 1");
            }
            else
            {
                Console.WriteLine("Nu este asa element");
            }
           


            //    A Dictionary stores Key-Value pairs where the key must be unique.
            //Before adding a KeyValuePair into a dictionary, check that the key does not exist using the ContainsKey() method.
            //Use the TryGetValue() method to get the value of a key to avoid possible runtime exceptions.
            //Use a foreach or for loop to iterate a dictionary.
            //Use dictionary indexer to access individual item.
            //Use custom class that derives IEqualityComparer to compare object of custom class with Contains() method.

            ArrayList myArryList1 = new ArrayList();
            IList arryList2 = new ArrayList()
{
    100, 200
};
            myArryList1.AddRange(arryList2);
            
            myArryList1.Add(567);
            myArryList1.Insert(3, 68);
myArryList1.Reverse(); 
            for(int i = 0 ; i< myArryList1.Count; i++)
    Console.WriteLine(myArryList1[i]);

            
            
            //sorteaza descrescator
            myArryList1.Sort();  //sorteaza ascendent
Console.WriteLine();
            //you can access elements of an array by indexer(int,string, float) or var keyword

       int thirdElement = (int) myArryList1[1]; 
 Console.WriteLine(thirdElement);
            Console.WriteLine();
            Console.WriteLine(myArryList1.Contains(100));
            Console.WriteLine();

            myArryList1.Remove("F");
            myArryList1.RemoveAt(1);

            foreach (var val in myArryList1)
 Console.WriteLine(val); 

           /*ArrayList can store items(elements) of any datatype.
            ArrayList resizes automatically as you add the elements.
            ArrayList values must be cast to appropriate data types before using it.
            ArrayList can contain multiple null and duplicate items.
            ArrayList can be accessed using foreach or for loop or indexer.
            Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.*/

            List<int> codProdus = new List<int>();
            codProdus.Add(456);
            codProdus.Add(466);
            codProdus.Add(476);
            codProdus.Add(486);
            List<int>produseNoi =new List<int>();
            produseNoi.AddRange(codProdus);

            codProdus.ForEach(el => Console.WriteLine(el));
           Console.WriteLine();
            foreach (var c in produseNoi)
    Console.WriteLine(c);
            Console.WriteLine();
           

            Console.WriteLine("numarul codurilor produselor: {0}",codProdus.Count);
            Console.WriteLine();
            produseNoi.Insert(4,10);
            foreach (var m in produseNoi)
                Console.WriteLine(m);
            Console.WriteLine();
            bool res=produseNoi.TrueForAll(m=>m%2==0);
            Console.WriteLine(res);

            /*List<T> stores elements of the specified type and it grows automatically.
            List<T> can store multiple null and duplicate elements.
            List<T> can be assigned to IList<T> or List<T> type of variable. It provides more helper method When assigned to List<T> variable
            List<T> can be access using indexer, for loop or foreach statement.
            LINQ can be use to query List<T> collection.
            List<T> is ideal for storing and retrieving large number of elements.*/
 Console.ReadKey();
        }
    }
}
