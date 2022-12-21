using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1
{
    class MaxTwoDimesionalArray
    {
        public void Display(int[,] arr)
        {
            int max = arr[0, 1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine(max);
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]); ;
                }
                Console.WriteLine(" ");
            }
            MaxTwoDimesionalArray m = new MaxTwoDimesionalArray();
            m.Display(a);
            Console.ReadLine();

        }
    } 
}
