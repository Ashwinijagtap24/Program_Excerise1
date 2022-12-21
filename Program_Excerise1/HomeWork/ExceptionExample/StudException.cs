using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.ExceptionExample
{
    public class StudException:Exception
    {
        public StudException(string message) : base(message)
        {

        }
    }
    public class Stud1
    {
        public Stud1()
        {
            string name;
            try
            {
                Console.WriteLine("Enter the  name");
                name = Console.ReadLine();
                if (name.Length == 0)
                {
                    throw new StudException("name is required");
                }
                
            }
            catch (StudException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("tnx");
            }
        }
        
        public static void Main(string[] args)
        {
            Stud1 s1 = new Stud1();
            
            Console.ReadLine();
        }
    }
    
}
