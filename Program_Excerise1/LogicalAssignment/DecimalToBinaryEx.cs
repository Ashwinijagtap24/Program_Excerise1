using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.LogicalAssignment
{
    class DecimalToBinaryEx
    {
        static void Main(string[] args)
        {
           int digit;
            string remainder=" ";
            Console.WriteLine("Enter the number");
           string n =Console.ReadLine();
            int num = Convert.ToInt32(n);
            while(num >1)
            {
                 digit = num  % 2;
                remainder = Convert.ToString(digit) + remainder;
                num = num / 2;

            }
            remainder = Convert.ToString(num) + remainder;
            Console.WriteLine($" reaminder = { remainder}");
            Console.ReadLine();
        }
    }
    class IntString
    {
        static void Main(string[] args)
        {
            int a = 205;
            Console.WriteLine(a);
            string num = Convert.ToString(a);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }

}
