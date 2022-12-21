using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    class StringBuiderExa
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello To World");
            Console.WriteLine(sb);
            sb.Append("Welcome to Seesion ");
            Console.WriteLine(sb);
            double price = 4500;
            sb.AppendFormat("price is {0:C}", price);
            Console.WriteLine(sb);
            Console.ReadLine();
        }

    }
}
