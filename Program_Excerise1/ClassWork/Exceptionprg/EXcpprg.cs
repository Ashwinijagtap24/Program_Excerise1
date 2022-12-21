using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.Exceptionprg
{
    class EXcpprg
    {
        static void Main(string[] args)
        {
            int a = 2, b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

        }
    }
    //mul catch
    class MulCatch
    {
        static void Main(string[] args)
        {
            int a = 2, b = 0;
            try
            {
                int[] arr = new int[5];
                arr[7] = 100;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("attemp divide by zero");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("out of range");
            }
        }
    }
}
