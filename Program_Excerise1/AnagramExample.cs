using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1
{
    class AnagramExample
    {
        static void Main(string[] args)
        {
            string str1 = "slient";
            string str2 = "listen";
            char[] ch = str1.ToCharArray();
            char[] ch1 = str2.ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);
            string s = new string(ch);
            string s2 = new string(ch);
            if(s == s2)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
            Console.ReadLine();
        }
    }
}
