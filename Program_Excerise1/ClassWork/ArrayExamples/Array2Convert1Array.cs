using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.ArrayExamples
{
    class Array2Convert1Array
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2, 3, 6,8,2};
            int[] a2 = new int[] { 5, 6, 7, 8, 9, 10 };
            List<int> l = new List<int>();
            for(int i=0;i<a1.Length;i++)
            {
                if (!l.Contains(a1[i]))
                    l.Add(a1[i]);
            }
            for (int i = 0; i < a2.Length; i++)
            {
                if (!l.Contains(a2[i]))
                    l.Add(a2[i]);
            }
            l.Sort();
            foreach(var items in l)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
}
