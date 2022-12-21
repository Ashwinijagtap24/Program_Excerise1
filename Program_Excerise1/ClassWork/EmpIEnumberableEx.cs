using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program_Excerise1.ClassWork
{
    class EmpIEnumberableEx 
    {
        private int id;
    private string name;
    private int sal;
    public EmpIEnumberableEx(int id, string name, int sal)
    {
            this.id = id;
        this.name = name;
        this.sal = sal;
    }
    public override string ToString()
    {
        return $"id = {id}, name = {name}, sal = {sal}";
    }

    }
    public class Emp2 : IEnumerable
    {
    private EmpIEnumberableEx[] emp1;

    public Emp2()
    {
        emp1 = new EmpIEnumberableEx[5];
        emp1[0] = new EmpIEnumberableEx(12, "seeta", 2000);
        emp1[1] = new EmpIEnumberableEx(13, "liza", 600);
        emp1[2] = new EmpIEnumberableEx(14, "mary", 70000);
        emp1[3] = new EmpIEnumberableEx(15, "poo", 8900);
        emp1[4] = new EmpIEnumberableEx(16, "mick", 8900);


    }

    public IEnumerator GetEnumerator()
    {
        return emp1.GetEnumerator();
    }
}
    public class Prg1
    {
           public static void Main(string[] args)
           {
            Emp2 e1 = new Emp2();
            foreach (EmpIEnumberableEx p in e1)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
  
    }
           
}
