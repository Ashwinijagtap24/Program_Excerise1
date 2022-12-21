using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.Array2DEx
{
    class A
    {
        public void Display(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine(" ");
            }

        }
        public static void Main(String[] args)
        {
            /* int[,] a = {{ 1,2,3},
                          {4,5,6},
                          {7,8,9},
                         {11,12,13 }
                              };
              */
            int[,] a = new int[4, 3];
            
            for(int i =0;i<a.GetLength(0);i++)
            {
                for(int j =0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(" ");
            }
            A a1 = new A();
            a1.Display(a);
            Console.ReadLine();
        }
    }
}
