using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.ArrayExamples
{
    class ExampleOfArray
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5] { 56, 85, 75, 95, 53 };
            Array.Sort(a);
            foreach(var arr in a)
            {
                Console.WriteLine("Sorting array = ");
                Console.WriteLine(arr);
            }
            // reverse array
            Array.Reverse(a);
            foreach(var arr in a)
            {
                Console.WriteLine("reverse array = ");
                Console.WriteLine(arr);
            }
            //decending array
            Array.Sort(a);
            Array.Reverse(a);
            foreach(var arr in a)
            {
                Console.WriteLine("deccending array=");
                Console.WriteLine(a);
            }
            //array copy to another array
            /*int[] a1 = new int[2];
            Array.Copy(a,a1,2);
            foreach()*/

        }
    }
}
