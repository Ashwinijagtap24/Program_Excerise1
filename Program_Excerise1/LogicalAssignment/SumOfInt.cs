using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.LogicalAssignment
{
    class SumOfInt
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the number a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a + b;
            Console.WriteLine($"result of aand b sum = {c}");
            Console.ReadLine();
        }
    }
    class NumberFrom1to100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("display number 1 to100");
            for (int i=0;i<=100;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    class EvenNumber1To100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("even no");
            for(int i=0;i<=100;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
    class OddNumber1To100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd number");
            for(int i=0;i<=100;i++)
            {
                if(i%2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
   class MaxNUmber
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            c = Convert.ToInt32(Console.ReadLine());
            if(a<b)
            {
                if(b>c)
                {
                    Console.WriteLine($"b is greater = {b} ");
                }
                else
                {
                    Console.WriteLine($"c is greater  = {c}");
                }
            }
            else
            {
                if(a>c)
                {
                    Console.WriteLine($"a is greater = {a}");
                }
                else
                {
                    Console.WriteLine($"C is greater = {c}");
                }
            }
            Console.ReadLine();
        }
    }
}
