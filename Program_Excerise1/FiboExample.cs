using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1
{
    class FiboExample
    {static void Main(string[] args)
        {
            int f1, f2=0, f3 = 1;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f2);
            for(int i =0;i<n;i++)
            { 
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
            Console.ReadLine();
        }
       
    }
}
