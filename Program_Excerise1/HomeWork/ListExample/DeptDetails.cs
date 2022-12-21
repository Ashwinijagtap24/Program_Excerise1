using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.ListExample
{
    public enum DepartmentType1 { HR, DEVE, TESTING }
    public class Employee1
    {
        public int  Id { set; get; }
        public string Name { set; get; }
      
    }
    
    public class DeptDetails
    {
        public int DeptId { get; set; }
       
        public DepartmentType1 DepartmentType1;
        public List<Employee1> elist = new List<Employee1>();
    }
    public class DeptDemo
    {
        static void Main(string[] args)
        {
            List<DeptDetails> dlist = new List<DeptDetails>()
            {
                new DeptDetails
                {
                    DeptId = 101,
                    DepartmentType1 = DepartmentType1.HR,
                    elist =
                    {
                        new Employee1 {  Id =1,Name="poonam" },
                        new Employee1 {  Id =2,Name="ashu" },
                        new Employee1 {  Id =3,Name="Mona "},
                    }

                },
                 new DeptDetails
                {
                    DeptId = 102,
                    DepartmentType1 = DepartmentType1.DEVE,
                    elist =
                    {
                        new Employee1 {  Id =4,Name="tina" },
                        new Employee1 {  Id =5,Name="seeta" },
                        new Employee1 {  Id =6,Name="geeta "},
                         new Employee1 {  Id =7,Name="meena "},
              
                    }

                  },
                 new DeptDetails
                {
                    DeptId = 103,
                    DepartmentType1 = DepartmentType1.TESTING,
                    elist =
                    {
                        new Employee1 {  Id =8,Name="laxmi" },
                        new Employee1 {  Id =9,Name="ritu" },
                        new Employee1 {  Id =10,Name="anu "},
                 
                    }

                  }
            };
            foreach(DeptDetails d in dlist)
            {
                Console.WriteLine($"Department Id = {d.DeptId} -> department type = {d.DepartmentType1} ");
                foreach(Employee1 e in d.elist)
                {
                    Console.WriteLine($" id = {e.Id} - name= {e.Name}");
                }
            }
            Console.ReadLine();
        }
    }

}
