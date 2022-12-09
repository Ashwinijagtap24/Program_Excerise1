using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    public class RefOutParamExample
    {
        //call by reference ....
        static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        //out keyword
        static void Cal(int a1,int b1 ,out int sum,out int sub,out int mul)
        {
            sum = a1 + b1;
            sub = a1- b1;
            mul = a1 * b1;
        }
        //Param keyword
        static void AcceptNames(params string[] name)
        {
            Console.WriteLine("values to print = "+name.Length);
            for(int i =0;i<name.Length;i++)
            {
                Console.WriteLine(name[i]);
            }
        }

       
        static void Main(string[] args)
        {
            // call  by reference ...
            int a = 10, b = 20;
            Console.WriteLine($"Before the method a = {a},b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After the method a= {a},b={b}");


            //Using out kryword....
            int a1 = 20, b1 = 30 ,sum,sub,mul;
            Cal(a, b, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

            //using param 
            AcceptNames("Ashu");
            AcceptNames("Ashu", "poonam");
            AcceptNames("ashu jagtap", "nikhil jagtap", "surekha");

            Console.ReadLine();
        }
       
       
    }
}
