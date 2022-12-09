using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    class StudDetails
    {
        private int  rollno{ get; set; }
        private string name{ get; set; }
        private int mobileno { get; set; }
        private static int  count = 0;
        public StudDetails(string name, int mobileno)
        {
            count++;
            rollno = count;
            this.name = name;
            this.mobileno = mobileno;
           
        }
        private static int CountNumber()
        {
            return count;

        }
        public void Display()
        {
            Console.WriteLine($"rollno =  {rollno}, \n name = {name} ,\n  mobile number = {mobileno} ");
        }
        static void Main(string[] args)
        {
            StudDetails s = new StudDetails("Ashu jagtap", 8999);
            StudDetails s1 = new StudDetails("poonam jagtap", 9929);
            StudDetails s2= new StudDetails(" jagtap", 8999);
            s.Display();
            s1.Display();
            s2.Display();
            Console.WriteLine("Count of student " +StudDetails.CountNumber());
            Console.ReadLine();
        }
       
    }
}
