using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork//namespace -logical group of type(class,struct,interface,delegate,event ,etc)
{  
    class Program//member - (firld,variable,method,Constructor,properties,indexing,event)
    {
        static void Main(string[] args)
        {

            /* EmpDetails e = new EmpDetails("Ashwini jagtap ", 250000);
             EmpDetails e1 = new EmpDetails("poonam jagtap ", 45000);
             EmpDetails e2 = new EmpDetails(" jagtap ", 45000);
             Console.WriteLine(e.ToString());
             Console.WriteLine(e1.ToString());
             Console.WriteLine(e2.ToString());
             Console.WriteLine("total count  = " + EmpDetails.CountNumber());
             Console.ReadLine();
 */
            
                int[] a = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < a.Length; i++)
                {
                    int flag = 0;
                    for (int j = 2; j <= 9; j++)
                    {
                        if (a[i] % j == 0)
                        {
                            flag++;
                        }


                    }
                if (flag == 0 || flag == 1)
                    {
                        Console.WriteLine(a[i]);
                    }



                }



            Console.ReadLine();

        }
    }
}
