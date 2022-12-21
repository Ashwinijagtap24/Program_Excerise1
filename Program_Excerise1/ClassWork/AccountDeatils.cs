using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    public  enum AccountDeatils{ saving ,current}
   
    public class Customer
    {
        public int Bankid { set; get; }
        public string Name { set; get; }
        public AccountDeatils AccountDeatils;
       public List<Loan> loans = new List<Loan>();
    }
    public class Loan
    { 
        public int Id { set;  get; }
        public string NameLoan { set; get; }


    }
    public class AccountListEx
    {
        public static void Main(string[] args)
        {
            List<Customer> ac = new List<Customer>()
            {
                new Customer
                {
                    Bankid = 10001,
                    Name = "Ashu",
                    AccountDeatils = AccountDeatils.saving,  
                    loans =
                    {
                        new Loan{Id = 12,NameLoan = "Car"},
                        new Loan{Id = 13,NameLoan ="house"},
                    }
                },
                new Customer
                {
                    Bankid = 100002,
                    Name = "Poonam",
                    AccountDeatils = AccountDeatils.current,
                    loans=
                    {
                        new Loan{Id=14 , NameLoan ="Personal"},
                        new Loan{Id=15,NameLoan="mobile "},
                    }

                }

            };
            foreach(Customer items in ac)
            {
                Console.WriteLine(items.Bankid);
                Console.WriteLine(items.Name);
                Console.WriteLine(items.AccountDeatils);
                foreach(Loan l in items.loans)
                {
                    Console.WriteLine("\t"+l.NameLoan);
                }
            }

            Console.ReadLine();
        }
    }
}
