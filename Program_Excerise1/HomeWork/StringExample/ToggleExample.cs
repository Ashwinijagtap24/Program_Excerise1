using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.StringExample
{
    class ToggleExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str =Console.ReadLine();
            
            char[] ch = str.ToCharArray();
            for (int i =0;i<str.Length;i++)
            {
                
                if(ch[i]>='a' && ch[i]<='z')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
                else if(ch[i]>='A' && ch[i]<='Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }

                Console.Write(ch[i]);
            }
            Console.ReadLine();

            
        }

    }
    //string palindrom
    class StringPalidrom
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string rev = new String(ch);
            bool check = str.Equals(rev);
            if(check == true)
            {
                Console.WriteLine("Its palindrome");
            }
            else
            {
                Console.WriteLine("Its not palindrome");
            }

            Console.ReadLine();
        }
    }
    //Occurence of Words
    class OccurenceWord
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string[] ch = str.Split(' ');
            for(int i =0;i<str.Length;i++)
            {
                int count = 1;
               for(int j=i+1;j<str.Length;j++)
                {
                   
                    if(str[i].Equals(str[j]))
                    {
                        count++;
                    }
                            
                }
           
                Console.WriteLine(str[i]+"-->"+count);
            }
            

            Console.ReadLine();
        }
      
    }
}
