using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    public class LoanDetails
    {
        public int HomeLoan { set; get; }
        public int Car { set; get; }
        public int PersonalLoan { set; get; }
    }
    public class Saving
    {
        public int Bankid { set; get; }
        public string Name { set; get; }
        public List<LoanDetails> Loan = new List<LoanDetails>();

    }
    public class Current
    {
        public int Bankid { set; get; }
        public string Name { set; get; }
        public List<LoanDetails> Loan1 = new List<LoanDetails>();
    }
    class BankAccountDetails
    {
        public static void Main(string[] args)
        {
            List<Saving> savings = new List<Saving>()
            {
                new Saving
                {
                    Bankid = 102,
                    Name = "ashu",
                   Loan ={
                        new LoanDetails {HomeLoan = 12000,Car = 15000},
                        
                    }

                },
                 new Saving
                 {
                    Bankid = 103,
                    Name = "poonam",
                   Loan ={
                        new LoanDetails {Car = 12000,HomeLoan = 1600},
             
                    }

                 },
            };
            List<Current> CurrentList = new List<Current>()
            {
                new Current
                {
                     Bankid =104,
                     Name = "tina",
                     Loan1 = {
                        new LoanDetails{PersonalLoan =  12000,Car=12000},
                        
                        }
                },

            };
           foreach(Saving save in savings)
            {
                Console.WriteLine("*****************");
                Console.WriteLine(" saving   bank details");
             
                Console.WriteLine($" bank id = {save.Bankid} ,\n name  = {save.Name}");
                foreach(LoanDetails l in save.Loan)
                {
                  
                    Console.WriteLine($"\thome loan = {l.HomeLoan},\tcar Loan = {l.Car},\tpersonal Loan={l.PersonalLoan}");
                   
                }
         
            }
            Console.WriteLine("*****************");
            foreach (Current C in CurrentList)
            {
                Console.WriteLine(" 2) current  bank details");
                Console.WriteLine($" band id = {C.Bankid} , \n bank  name = {C.Name}");
                foreach (LoanDetails l1 in C.Loan1)
                {

                    Console.WriteLine($"\tcar loan = {l1.Car}");
                    Console.WriteLine($"\tpersonal  loan = {l1.PersonalLoan}");
                }

            }
            Console.ReadLine();
        }
    }
}

    
