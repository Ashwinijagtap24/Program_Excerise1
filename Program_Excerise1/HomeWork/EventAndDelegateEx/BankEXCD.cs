using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.EventAndDelegateEx
{


    /*public delegate void Mydelegate();
    public class Bank
    {
        double balance;
        public event Mydelegate Zero;
        public event Mydelegate Less;

        public Bank(double balance,double amt)
        {
            this.balance = balance;
            this.amt = amt;
        }
        public void Credit()
        {
            balance = amt + balance;
        }
        public void Debit()
        {
            if(amt<balance)
            {
                balance = amt - balance;
            }
            else if(amt>balance)
            {
                Less();
            }
            else
            {
                Zero();
            }
          
        }
        
    }
   public class Message
    {
        public static void LessMessage()
        {
            Console.WriteLine("insufficient balance");
        }
        public static void ZeroMessage()
        {
            Console.WriteLine("Zero balance");
        }
            

    }
        
       
   public class BankDetails
    {
        public static void Main(string[] args)
        {
            Bank b = new Bank(1200, 2555);
            b.Less += new Mydelegate(Message.LessMessage);
            b.Zero += new Mydelegate(Message.ZeroMessage);
            Console.WriteLine("Credit");
            b.Credit();
            Console.WriteLine("debit");
            b.Debit();
            Console.ReadLine();
     
        }
    }*/
    public delegate void Mydell();
    public class Bank
    {
        private double blc;
        public event Mydell Less;
        public event Mydell Zero;
        public Bank( double blc)
        {
            this.blc = blc;
                
        }
        public void Credit(double amt)
        {
            blc = amt + blc;
        }
        public void Deposit(double amt)
        {
            if(amt>blc)
            {
                Less();
            }
            else
            {
                blc = amt;
                if(blc==0)
                {
                    Zero();
                }
            }
        }
        public override string ToString()
        {
            return $"Current balance  is {blc}";
        }
    }
    public static class Message
    {
        public static void LessMessage()
        {
            Console.WriteLine("insufficient balance");
        }
        public static void ZeroMessage()
        {
            Console.WriteLine("Zero balance");
        }


    }
    public class BankDetails
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(5000);
            b.Less += new Mydell(Message.LessMessage);
            b.Zero += new Mydell(Message.ZeroMessage);
            Console.WriteLine("Credit of 1000");
            b.Credit(1000);
            Console.WriteLine(b);
            Console.WriteLine("debit of 15000");
            b.Deposit(15000);
            Console.WriteLine(b);
            Console.WriteLine("debit of 6000");
            b.Deposit(6000);
            Console.WriteLine(b);
            Console.ReadLine();

        }
        


    }
}
