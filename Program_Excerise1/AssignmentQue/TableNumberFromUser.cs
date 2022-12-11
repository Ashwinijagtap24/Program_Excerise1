using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.AssignmentQue
{
    class TableNumberFromUser
    {
        public void Display(int n)
        {
            int result = 0;
            for(int i = 1; i<=10;i++)
            {
                result = i * n;
                Console.WriteLine($"{n} * {i} = {result} ");
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int a = Convert.ToInt32(Console.ReadLine());
            TableNumberFromUser t = new TableNumberFromUser();
            t.Display(a);
            Console.ReadLine();
            
        }
    }
}
