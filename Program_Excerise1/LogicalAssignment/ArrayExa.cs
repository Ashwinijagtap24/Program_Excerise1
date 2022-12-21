using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.LogicalAssignment
{   //Display array
    class ArrayExa
    {
        static void Main(string[] args)
        {
            int[] a =new int[20];
            for(int i = 0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
    // even array 
    class EvenNoInArray
    {
        public void Display(int[] arr)
        {
            Console.WriteLine("enven number");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Display Array ");
            for(int i =0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            EvenNoInArray e = new EvenNoInArray();
            e.Display(a);
            Console.ReadLine();
        }
    }
    //max number from array 
    class MaxNUmberInArr
    {
        public void Display(int[] arr)
        {
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine($"max = {max}");
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            MaxNUmberInArr m = new MaxNUmberInArr();
            m.Display(a);
            Console.ReadLine();
        }
    }
    //create table of number
    class TableNumber
    {
        static void Main(string[] args)
        {
            int a,result;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"table of {a} ");
            for (int i=1;i<=10;i++)
            { 
                result = a * i;
                Console.WriteLine(result);
            }
           
            Console.ReadLine();
        }
    }
    //given number odd or even number
    class EvenOddNu
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine($"Even number = {a}");
            }
            else
            {
                Console.WriteLine($"odd number = {a}");
            }
            Console.ReadLine();
        }
    }
    // prime number or not
    class PrimeExmaple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
           for(int i = 1;i<=a;i++)
            {
                if(a%i==0)
                {
                    flag++;

                }
            }
           if(flag == 2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
                Console.ReadLine();
            
        }
    }
    //cal factorial
    class FactExample
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for(int i=1;i<=a;i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine("factt="+fact);
            Console.WriteLine("sum = "+sum);
            Console.ReadLine();
        }
    }
    // exponent//power
    class ExpobaseEx
    {
        static void Main(string[] args)
        {
           double a, b;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the expo");
            b = Convert.ToInt32(Console.ReadLine());
          int result;
            result =Convert.ToInt32(Math.Pow(a,b));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    // count number of Digit in any no
   
}

