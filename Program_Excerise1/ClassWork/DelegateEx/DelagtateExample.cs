using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.DelegateEx
{
    public delegate int Mydel(int a, int b);
    public delegate string Mydel1(string name);
    class DelagtateExample
    { 
        public int M1(int a,int b)
        {
            return a + b;
        }
        public string M2(string name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            DelagtateExample d = new DelagtateExample();
            Mydel x = new Mydel(d.M1);
            Mydel1 y = new Mydel1(d.M2);
            int sum = x.Invoke(56, 36);
            Console.WriteLine($"sum = {sum}");
            string name = y.Invoke("Ashu");
            Console.WriteLine($"name = {name}");
        }
    }
}
