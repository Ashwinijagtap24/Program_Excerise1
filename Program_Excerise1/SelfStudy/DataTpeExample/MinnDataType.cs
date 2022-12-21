using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.SelfStudy.DataTpeExample
{
    //Find min Data type  like - int float double,Decimal
    class MinnDataType
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine($"Minimum range of Data type int = {int.MinValue}");
            Console.WriteLine($"max Value = {int.MaxValue}");
            Console.WriteLine($"Minimum range of Data type float ={float.MinValue}");
            Console.WriteLine($"max range  = {float.MaxValue}");
            Console.WriteLine($"minimum rang eof data type decimal = {decimal.MinValue}");
            Console.WriteLine($"Max Value = {decimal.MaxValue}");
            Console.WriteLine($"Minimum range of Data TYpe double = {double.MinValue }");
            Console.WriteLine($"max Value = {double.MaxValue}");
            Console.ReadLine();

        }
        

    }
    //Perform Arith matic operation 
    class ArithmaticOpe
    {
        static  void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Entr the num and b");
            a =Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Additionn = {a+b}");
            Console.WriteLine($"sub = {a-b}");
            Console.WriteLine($"mul = {a*b}");
            Console.WriteLine($"div = {a/b}");
            Console.ReadLine();

        }
    }
    //age is greter thean 18 Adult is true or false
    class AgeNotify
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool adult = age >18? true : false;
            Console.WriteLine($"Adult = {adult}");
            Console.ReadLine();
        }
    }
}
