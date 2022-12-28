using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.DelegateEx
{
    public delegate int Mydel2(int a, int b);
    class MultiCastDelegate
    {
        public int M1(int a,int b)
        {
            return a + b;
        }
        public int M2(int a,int b)
        {
            return a * b;
        }
        public int M3(int a,int b)
        {
            return a / b;
        }
        public int M4(int a,int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            MultiCastDelegate md = new MultiCastDelegate();
            Mydel2 m = new Mydel2(md.M1);
            m += new Mydel2(md.M2);
            m += new Mydel2(md.M3);
            m += new Mydel2(md.M4);
            Delegate[] list = m.GetInvocationList();
            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(50,60));
            }
            Console.ReadLine();
        }
    }
}
