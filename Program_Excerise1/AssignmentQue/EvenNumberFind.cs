using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.AssignmentQue
{
    class EvenNumberFind
    {
        public void Display()
        {
            for(int i=0;i<=10;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("Even number " + i);
                }
                else
                {
                   // Console.WriteLine("odd number " + i);
                }
            }
        }
        static void Main(string[] args)
        { 
           
            EvenNumberFind e = new EvenNumberFind();
            e.Display();
            Console.ReadLine();
        }
    }
}
