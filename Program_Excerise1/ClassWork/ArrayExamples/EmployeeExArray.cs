using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork.ArrayExamples
{
    class EmployeeExArray
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    }
    class Student
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public Student(int sid,string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
        public override string ToString()
        {
            return $"{sid}->{sname}";
        }
    }
    public class Main1
        {
        public static void Main(string[] args)
        {
            EmployeeExArray[] EmplyooeList = new EmployeeExArray[]
            {
                new EmployeeExArray{id = 101,name = "ashu",salary = 4000},
                new EmployeeExArray{id =102,name = "poonam",salary = 5000},
                new EmployeeExArray{id =103,name = "asass",salary = 6000}

            };
            foreach (EmployeeExArray a in EmplyooeList)
            {
                Console.WriteLine($"{a.id},{a.name},{a.salary}");
            }
            Console.WriteLine("//////////");
            Console.WriteLine("using constructor");
            Student[] s = new Student[]
            {
                new Student(1,"ashu"),
                new Student(2,"poonamw")

             };
            foreach (Student List in s)
            {
                Console.WriteLine(List);
            }


            Console.ReadLine();

        }

        }
}
