using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.SelfStudy.ArrayExap
{
    //Length.of Array
    class ArrayLength
    {
        static void Main(string[] args)
        {
            int[] aar = new int[10];
            Console.WriteLine(aar.Length);
            int[,] a = new int[10, 6];
            Console.WriteLine(a.Length);
            Console.ReadLine();
        }
    }
    //Reverce the array
    class ArrayReverce
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            
            Array.Reverse(a);
            for(int i =0;i<6;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
    // find MaxElement in Array
    class MaxElementArray
    {
        public void  Display(int[] arr)
        {
            int max = arr[0];

            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine("////////");
            Console.WriteLine($"Max = {max}");

        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            MaxElementArray h = new MaxElementArray();
            h.Display(a);
            Console.ReadLine();
        }
    }
    //Min Array
    class MinArrayExample
    {
        public void Display(int[] arr)
        {
            int min = arr[0];
            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            MinArrayExample m = new MinArrayExample();
            m.Display(a);
            Console.ReadLine();
        }
    }
}
