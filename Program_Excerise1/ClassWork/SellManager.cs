using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    public class Emplyooee
    {
        protected int id;
        protected string name;
        
        protected double bs, gross, hra, da, pf;
        public Emplyooee(int id, string name, double bs)
        {
            this.id = id;
            this.name = name;
           
            this.bs = bs;
        }
        public void Salary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = bs + hra + da - pf;


        }
        public override string ToString()
        {
            return $" Sell Manager = \n id = {id} , name = {name}  , bs = {bs} , gross= {gross}";
        }


    }
   public  class SellManager : Emplyooee
    {
        private double comm;
        private double bonus;
          public  SellManager(int id ,string name, double bs,double comm,double bonus):base(id,name,bs)
            {
                this.comm = comm;
                this.bonus = bonus;
            }

        public new void Salary()
        {
          //  base.print();
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = (hra + da  + comm + bonus)-pf;
        }


        public override string ToString()
        {
            return $" Sell Manager = \n id = {id} , name = {name}  , bs = {bs} , gross= {gross}";
        }
        //Sell MAngaer
        public static void Main(string[] args)
        {
            SellManager s1 = new SellManager(101, "Poonam", 20000.20, 1000.25, 500.26);
            s1.Salary();
            s1.ToString();
            // s1.print();
            Console.WriteLine(s1);

            Emplyooee e1 = new Emplyooee(1063, "Rani ", 30000.56);
            e1.Salary();
            e1.Salary();
            Console.WriteLine(e1);
        }
    }

}

