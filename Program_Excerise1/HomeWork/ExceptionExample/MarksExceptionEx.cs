using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.ExceptionExample
{
    class MarksExceptionEx :Exception
    {
        public MarksExceptionEx(string message) : base(message)
        {

        }
    }
    class StudMarkss
    {
        int marks;
        public void Display()
        {
            try
            {
                Console.WriteLine("Enter tthe number");
                marks = Convert.ToInt32(Console.ReadLine());
                if (marks > 100)
                {
                    throw new MarksExceptionEx("out of bounds");
                }
                else
                {
                    this.marks = marks;
                }
            }
            catch(MarksExceptionEx e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("ok");
            }
        }
        public static void Main(string[] args)
        {
            StudMarkss s = new StudMarkss();
            s.Display();
            Console.ReadLine();
        }
    }
  
}
