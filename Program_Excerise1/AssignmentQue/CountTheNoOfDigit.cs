using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.AssignmentQue
{
    class CountTheNoOfDigit
    {
        public void Display(int n )
        {
            int sum = 0;
            int digit;
            while(n>0)
            {
                digit = n % 10;
                sum = sum + digit;
                n = n / 10;

            }
            Console.WriteLine($"sum = {sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int a = Convert.ToInt32(Console.ReadLine());
            CountTheNoOfDigit c = new CountTheNoOfDigit();
            c.Display(a);
            Console.ReadLine();

        }
    }
}
