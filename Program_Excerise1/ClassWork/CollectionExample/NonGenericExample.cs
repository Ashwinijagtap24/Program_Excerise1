using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.CollectionExample
{
    class NonGenericExample
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(50);
            Console.WriteLine($"Count = {list.Count}");
            foreach(var items in list)
            {
                Console.WriteLine($"List = {items }");
            }
            list.RemoveAt(2);
            Console.WriteLine("****************");

            List<string> list2 = new List<string>();
            list2.Add("Ashu");
            list2.Add("poonam");
            list2.Add("pournima");
            Console.WriteLine( $"count = {list2.Count}");
            foreach(var items in list2)
            {
                Console.WriteLine($"List-2 {items}");
            }
            Console.WriteLine("****************");

            Dictionary<int, String> d = new Dictionary<int, string>();
            d.Add(1, "Ashu");
            d.Add(2, "pooname");
            d.Add(24, "nikhya");
            Console.WriteLine($"Count = {list.Count}");
            foreach(KeyValuePair<int,string> items in d)
            {
                Console.WriteLine(items.Key+"-->"+items.Value);
            }
            Console.WriteLine("****************");

            Dictionary<int, double> d1 = new Dictionary<int, double>();
            d1.Add(24, 12.3);
            d1.Add(30, 3.50);
            d1.Add(5, 2);
            Console.WriteLine($"Count = {list.Count}");
            Console.WriteLine("Dictionary");
            foreach (KeyValuePair<int,double> items in d1 )
            {
                
                Console.WriteLine(items.Key+" "+items.Value);
            }
            Console.WriteLine("****************");

            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(54, "Ashu");
            s.Add(24, "poonam");
            s.Add(69, "mona");
            s.Add(2, "tanu");
            Console.WriteLine($"Count = {list.Count}");
            Console.WriteLine($"Sorted List");
            foreach (KeyValuePair<int,string> items in s)
            {
               
                Console.WriteLine(items.Key+" ->"+items.Value);
            }
            Console.WriteLine("****************");
            Console.ReadLine();

        }
                          
    }
}
