using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.AssignmentQue
{
    class NoisArmstronOrNot
    {
        public void Display(int n)
        {
            Console.WriteLine($"number = " + n);
            int temp = n;
            int digit;
            int result = 0;
            while(n>0)
            {
                digit = n % 10;
                result = result + (digit * digit * digit);
                n = n / 10;

            }
            Console.WriteLine($"Result = {result}");
            if (result == temp )
            {
                Console.WriteLine("Armstrong number ");
            }
            else
            {
                Console.WriteLine("Number is not armstrong ");

            }

        }

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number ");
            num = Convert.ToInt32(Console.ReadLine());
            NoisArmstronOrNot na = new NoisArmstronOrNot();

            na.Display(num);
            Console.ReadLine();

        }
    }
}
