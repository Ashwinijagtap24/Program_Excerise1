using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program_Excerise1
{
    class BegingAndEndArray
    {
        public void ZeroFirst(int[] a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                   if(a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        public void ZeroLast(int[] a)
        {
            for (int i = a.Length - 1; i >=1 ; i--)
            {
                for (int j = i -1; j >=0; j--)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 6 };
            Console.WriteLine("original array");
            foreach(var items in a)
            {
                Console.WriteLine(items);
            }
            BegingAndEndArray b = new BegingAndEndArray();
            b.ZeroFirst(a);
            foreach(var item in a)
            {
                Console.WriteLine(item);
            }
        
            b.ZeroLast(a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();



        }
    }
}
