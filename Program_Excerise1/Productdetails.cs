using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1
{
    public partial class Productdetails
    {
        private int id;
        private string name;
        private double price;
       
         public  int Id { set; get; }
        public string Name { set; get; }
         public double Price
        {
            set { if (Price > 2000)
                   price = value;
                    
                }
            get { return price; }
        }

        public override string ToString()
        {
            return $"id{id},name={name},price{price}";
        }

    }

}

