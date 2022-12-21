using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.StringExam
{
    class StringEx1
    {
        public static void Main(String[] args)
        {
            string str1 = "Good Morning ";
            Console.WriteLine(str1.Length);
           
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());
            string str2 = " hello";
            Console.WriteLine(String.Concat(str1, str2));
            str1.Trim();
            char[] ch = str1.ToCharArray();
            foreach (var items in ch)
            {
                Console.WriteLine(items);
                
            }
            int a = string.Compare(str1, str2);
            Console.WriteLine(a);
            bool b = str1.Equals(str2);
            Console.WriteLine(b);
            string str4 = "test";
            Char[] C = { 't', 'e', 's', 't' };
            //onject str5 = new string(C);
            string str5 = new string(C);
            bool re = str4.Equals(str5);
            Console.WriteLine(re);
            if(str4 == str5)
            {
                Console.WriteLine("true");
            }
            else{
                Console.WriteLine("false");
            }

      

            Console.ReadLine();

        }
    }
}
