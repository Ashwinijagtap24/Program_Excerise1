using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork
{
    class StudentDetails
    {
        int Roll_no;
        string Name;
       
        public StudentDetails(int Roll_no,string Name)
        {
            this.Roll_no = Roll_no;
            this.Name= Name;
        }
        int Marathi, English, Maths;
        double sum = 0;
       double Per = 0;

        public void PerCalCulate()
        {
            Marathi = 75;
            English = 80;
            Maths = 75;

            sum = Marathi + English + Maths;
            Per = (sum/300)*100;


        }
        public void Print()
        {
            Console.WriteLine("Student Roll Number = "+Roll_no +" \n Student name =" +Name+ "\nSum of marks ="+sum+ "\nPercentage = "+Per);
        }
        public  double SumOfMarks()
        {
            return sum;
        }
        public double PerOfMarks()
        {
            
            return Per;
        }

        public
        static void Main(string[] args)
        {
            StudentDetails s = new StudentDetails(2410,"Ashwini jagtap");
 
            s.PerCalCulate();
            s.Print();
          
            Console.ReadLine();


        }
    }
}
