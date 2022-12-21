using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program_Excerise1.ClassWork
{
    public class EmpICompareSal:IComparable
    {
        private int rollno;
        private string name;
        private int sal;
        public EmpICompareSal(int rollno,string name,int sal)
        {
            this.rollno = rollno;
            this.name = name;
            this.sal = sal;

        }
        public override string ToString()
        {
            return $"roll no = {rollno},name = {name} , sal = {sal}";
        }
        public int CompareTo(object obj)
        {
            EmpICompareSal ep3 = (EmpICompareSal)obj;
            if (this.sal > ep3.sal)
            {
                return 1;

            }
            else if (this.sal < ep3.sal)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }



        public static void Main(string[] args)
        {
             EmpICompareSal ep = new EmpICompareSal(1,"pooja",20000);
            EmpICompareSal ep1 = new EmpICompareSal(2, "rina", 30000);
            EmpICompareSal ep3 = new EmpICompareSal(3, "tina",10000);
            EmpICompareSal ep4 = new EmpICompareSal(4, "arya", 50000);
            EmpICompareSal ep5= new EmpICompareSal(5, "meena", 1000000);
            Console.WriteLine(ep.ToString());
            Console.WriteLine(ep1.ToString());
           // Console.WriteLine(ep2.ToString());
            Console.WriteLine(ep3.ToString()); 
            Console.WriteLine(ep4.ToString()); 
            Console.WriteLine(ep5.ToString()); 

            int result = ep5.CompareTo(ep4);
            if(result == 1)
            {
                Console.WriteLine("########################");
                Console.WriteLine("meena has more sal than arya");
            }
            else if (result == -1)
            {
                Console.WriteLine("########################");
                Console.WriteLine("meena has less sal than arya");
            }
           else
            {
                Console.WriteLine("########################");
                Console.WriteLine("meena & arya is equal");
            }

            Console.ReadLine();
        }

       
    }
    
    
}
