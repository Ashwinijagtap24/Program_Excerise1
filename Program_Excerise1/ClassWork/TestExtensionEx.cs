using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
   public  class TestExtensionEx
    {
        public void M1()
        {
            Console.WriteLine("hiii..M1 method");
        }
        public void M2()
        {
            Console.WriteLine("hiii...M2 Method");
        }
    }
    public static class ExtensionClass
    {
        public static void M3(this TestExtensionEx t, string name)
        {
            Console.WriteLine("hiii ...M3 Method"+name);
        }
    }
   public  class Prg
    {
        public static void Main(string[] args)
        {

            TestExtensionEx t = new TestExtensionEx();
            t.M3("Ashu");
            Console.ReadLine();
        }
    }
}

