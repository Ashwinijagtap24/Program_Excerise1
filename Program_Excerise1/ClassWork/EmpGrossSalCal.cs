using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    class EmpGrossSalCal
    {
        /* static void Main(string[] args)
         {
             int year = 2022;
             string Comapany_name = "Think Quotient";
             // 3 type to diplay the data member 
             //1= +
             Console.WriteLine("Comapny name = " + Comapany_name + "year= " + year);
             //2= .(place holder)=,
             Console.WriteLine("Company name {0} and year {1}", Comapany_name, year);
             //3 = $
             Console.WriteLine($"Comapny name {Comapany_name} and year {year}");
             Console.ReadLine();
         }*/
       private int emp_id;
       private string emp_name;
        private double basis, hra, da, pf, gross;
        //constructor
        public EmpGrossSalCal(int emp_id,string emp_name,double basis)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.basis = basis;

        }
        //specific task
        public void CalculationSal()
        {
            hra = basis * 0.40;
            da = basis * 0.20;
            pf = basis * 0.12;
            gross = hra + basis + da + pf;
        }
        public void Display()
        {
            Console.WriteLine("emp Id " + emp_id + " emp name " + emp_name + " grossSal " + gross);
        }
        //ToString -string Represent of a object
       public double GetSal()
        {
            return gross;
        }
        static void Main(string[] args)
        {
            EmpGrossSalCal e = new EmpGrossSalCal(2410,"Ashu",23000.25);
            e.CalculationSal();
            /*  string data = e.Print();
              Console.WriteLine(data);

             */
            e.Display();
            Console.ReadLine();
        }
    }
   
}
