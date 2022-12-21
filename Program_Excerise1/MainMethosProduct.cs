using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program_Excerise1
{ 
  public partial class Productdetails
    {
        public static void Main(string[] args)
        {
            Productdetails p = new Productdetails { id = 1, name = "ice cream", price = 30000 };

            Productdetails p1 = new Productdetails { id = 12, name = "icone", price = 1200 };

            Productdetails p3 = new Productdetails { id = 13, name = "ichocobar", price = 6300 };

            Productdetails p4 = new Productdetails { id = 14, name = "Havmor", price = 600 };

            List<Productdetails> l = new List<Productdetails>();
            l.Add(p);
            l.Add(p1);
            l.Add(p3);
            l.Add(p4);
            foreach (Productdetails d in l)
            {

                Console.WriteLine(d.id);
                Console.WriteLine(d.name);
                Console.WriteLine(d.price);

            }
            Console.WriteLine(p.ToString());
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
            Console.ReadLine();
        }
    }
}
