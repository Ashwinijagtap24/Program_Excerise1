using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program_Excerise1.ClassWork.ThreadExample
{
    public class ThreadCreate1
    {
        public void M1()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    //Thread.Sleep(2000);
                }
            }
        }
        public void M2()
        {
            for(int i = 11;i<=15;i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(2000);
            }
        }
    }
    public class CreateThread
    {
        public static void Main(string[] args)
        {
            ThreadCreate1 tc = new ThreadCreate1();
            Thread t1 = new Thread(new ThreadStart(tc.M1));
            Thread t2 = new Thread(new ThreadStart(tc.M2));
            Thread t3 = new Thread(new ThreadStart(tc.M1));
            t1.Start();
            t2.Start();
            t3.Start();//lock kelyamule applyala` je output ahe te line by line execute hoil
            Console.ReadLine();
        }
    }
    class RefOutEx
    {
        public void Update(out int a)
        {
            a = 10;
        }
        public void Change(ref int d )
        {
            d = 11;
        }
        public void Main(string[] args)
        {
            int b;
            int c = 12;
            RefOutEx r = new RefOutEx();
            Update(out b);
            Change(ref c);
            Console.WriteLine($"b= = {b}");
            Console.WriteLine($"c == {c}");
            Console.ReadLine();

        }

    }
   }
    class PramEx
    {
        public void Accept(params string[] name)
        {
            Console.WriteLine("value of print " + name.Length);
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
        public static void Main(string[] args)
        {
        PramEx p = new PramEx();
        p.Accept("Ashu", "tina");
        p.Accept("jagtap");
        p.Accept("dsjcndj", "bcydushgcuhdsb,", "ubdjhnsjadnxja","hsdjbs");
        Console.ReadLine();
        }
    }
}
