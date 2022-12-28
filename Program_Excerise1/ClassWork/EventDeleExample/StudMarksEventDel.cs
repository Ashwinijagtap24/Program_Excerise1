using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.EventDeleExample
{
    public delegate void Mydel();
    public class Marks
    {
        public event Mydel Pass;
        public event Mydel Fail;
        public void Accept(int marks)
        {
            if(marks>=40)
            {
                Pass();
            }
            else
            {
                Fail();
            }
        }
    }
    public static class Message
    {
        public static void PassMessage()
        {
            Console.WriteLine("great! you are pass");
        }
        public static void FailMessage()
        {
            Console.WriteLine("sorry ! you are fail");
        }
    }
    class StudMarksEventDel
    {
        static void Main(string[] args)
        {
            Marks m = new Marks();

            m.Pass += new Mydel(Message.PassMessage) 
                ;
            m.Fail += new Mydel(Message.FailMessage);
            m.Accept(38);
            Console.ReadLine();
        }
    }
}
