using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.AssignmentQue
{
    class SwapValueOfTwoNo
    {
        public void Display(int x ,int y)
        {
         
            Console.WriteLine("befor swap the value");
            Console.WriteLine("a = " + x);
            Console.WriteLine("b = " + y);
            Console.WriteLine("After swap the value");
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("a = " + x);
            Console.WriteLine("b = " + y);

        }
        static void Main(string[] args)
        {
            int a ,b;
            Console.WriteLine("Enter the number of a and  b number ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            SwapValueOfTwoNo s = new SwapValueOfTwoNo();
            s.Display(a, b);
            Console.ReadLine();
        }
    }
}
