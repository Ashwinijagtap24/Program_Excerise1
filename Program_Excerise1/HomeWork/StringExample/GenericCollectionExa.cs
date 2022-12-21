using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.StringExample
{
    class GenericCollectionExa
    {
        int rollno;
        string name;
        double marks;
        static void Main(string[] args)
        {
            GenericCollectionExa g = new GenericCollectionExa();
            g.rollno = 54;
            g.name = "Ashu";
            g.marks = 70.76;
            Console.WriteLine(  "/////////////");
            GenericCollectionExa g1 = new GenericCollectionExa();
            g1.rollno = 42;
            g1.name = "poonam";
            g1.marks = 64.32;
            Console.WriteLine("################################");
            List<GenericCollectionExa> gen = new List<GenericCollectionExa>();
            gen.Add(g);
            gen.Add(g1);
            Console.WriteLine("* List *");
            foreach(var items in gen)
            {
                Console.WriteLine(items.rollno);
                Console.WriteLine(items.name);
                Console.WriteLine( items.marks);
            }
            Console.WriteLine("################################");
            Stack<int> s = new Stack<int>();
            s.Push(g.rollno);
            s.Push(g1.rollno);
            Console.WriteLine("* Stack *");
            foreach (var items in s)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("################################");
            Queue<string> q = new Queue<string>();
            q.Enqueue(g.name);
            q.Enqueue(g1.name);
            Console.WriteLine("* Queue *");
            foreach (var items in q)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("################################");
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(g.rollno, g.name);
            d.Add(g1.rollno, g1.name);
            Console.WriteLine("* Dictionary *");
            foreach (KeyValuePair<int,string> items in d)
            {
                Console.WriteLine(items.Key+" --> "+items.Value);
            }
            Console.WriteLine("################################");
            SortedList<int, double> s1 = new SortedList<int, double>();
            s1.Add(g.rollno, g.marks);
            s1.Add(g1.rollno, g1.marks);
            Console.WriteLine("*  SortedList*");
            foreach (KeyValuePair<int,double> items in s1 )
            {
                Console.WriteLine(items.Key+" --> "+items.Value);
            }
            Console.ReadLine();
                
        }
    }
}
