using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    class MethodOverlodingExAdd
    {
        public int Add(int a ,int b )
        {
            return a + b;
        }
        public int Add(int a,int b ,int c)// no of parameter
        {
            return a + b + c;
        }
        public double Add(int a,double b) // no of type
        {
            return a + b;
        }
        public double Add(int a, double b, double c)//order
        {
            return a + b + c;
        }
        public static void Main(string[] args)
        {
            MethodOverlodingExAdd m1 = new MethodOverlodingExAdd();
           Console.WriteLine( m1.Add(12,1,6));
            Console.ReadLine();

        }
       
    }
   
}
