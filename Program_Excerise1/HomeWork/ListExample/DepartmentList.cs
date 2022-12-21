using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.ListExample
{
   public enum DepartmentType { HR,DEVE,TESTING}
    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DepartmentType DepartmentType;
        public List<Department> list = new List<Department>();
    }
    public class Department
    {
        public int DepartmentId { set; get; }
        public string DepartmentName { set; get; }
        
    }
    public class DepartmentList
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>()
            {
                new Employee
                {
                    Id =1,
                    Name ="Ashu",
                    DepartmentType = DepartmentType.HR,
                    list=
                    {
                        new Department { DepartmentId=101,DepartmentName="HR"}
                    },
                },
                new Employee
                {
                    Id=2,Name="poonam",
                    DepartmentType =DepartmentType.HR,
                    list=
                    {
                        new Department{DepartmentId= 102,DepartmentName="HR"}
                    }
                },
                new Employee
                {
                    Id=3,Name="mona",
                    DepartmentType =DepartmentType.HR,
                    list=
                    {
                        new Department{DepartmentId= 103,DepartmentName="HR"}
                    }
                },
                 new Employee
                 {
                    Id=4,Name="tanu",
                    DepartmentType =DepartmentType.DEVE,
                    list=
                    {
                        new Department{DepartmentId= 104,DepartmentName="Developer"},
                    }
                 },
                  new Employee
                  {
                    Id=5,Name="aruu",
                    DepartmentType =DepartmentType.DEVE,
                    list=
                    {
                        new Department{DepartmentId= 105,DepartmentName="Developer"},
                    }
                  },
                 new Employee
                 {
                     Id =6,Name = "soni",
                     DepartmentType =DepartmentType.TESTING,
                     list=
                     {
                         new Department{DepartmentId = 106,DepartmentName="testing"}
                     }
                 }
            };
            foreach(Employee item in elist)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DepartmentType);
                foreach(Department d in item.list)
                {
                    Console.WriteLine("\t"+d.DepartmentName);
                }
            }
            Console.ReadLine();
        }
    }
}
