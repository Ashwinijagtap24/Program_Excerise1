using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    class EmpDetails
    {
        private int empid;
        private string name;
        private int sal;
       private static int count=0;
        public EmpDetails(string name,int sal)
        {
            count++;
            empid = count;
            this.name = name;
            this.sal = sal;
        }
        public override string ToString()
        {
            return $"{empid} -> {name} -> {sal}";
        }
       public static  int CountNumber()
        {
            return count;
        }

    }
}
