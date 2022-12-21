using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program_Excerise1.ClassWork.CollectionExample
{
    class StackHashQueueExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Example");
            Stack s = new Stack();
            s.Push(10);
            s.Push(12);
            s.Push(13);
            s.Pop();
            Console.WriteLine($"top of element{s.Peek()} ");
            foreach(var items in s)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();

        }
    }
    class QueueExample
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("queue example");
            Queue Q = new Queue();
            Q.Enqueue(190);
            Q.Enqueue(120);
            Q.Enqueue(130);
            Q.Enqueue(150);
            Q.Dequeue();
            Console.WriteLine(Q.Count);
            Console.WriteLine($"Top of the elment in Queue {Q.Peek()}");
            foreach(var items in Q)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
    class HashExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash  Example ");
            Hashtable h = new Hashtable();
            h.Add(24, "Ashu");
            h.Add(23, "tanu");
            h.Add(10, "mona");
            h.Add(30, "nikhya");
            h.Remove(23);
            foreach(DictionaryEntry items in h)
            {
                Console.WriteLine(items.Key+" "+items.Value);
            }

            Console.ReadLine();
        }
    }
    class SortedListExample
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(91, "xyx");
            s.Add(85, "abxc");
            s.Add(96, "wer");
            s.Add(45, "okoko");
            
            foreach(DictionaryEntry items in s)
            {
                Console.WriteLine(items.Key + " " + items.Value);



            }
            Console.ReadLine();
        }
    }

}
