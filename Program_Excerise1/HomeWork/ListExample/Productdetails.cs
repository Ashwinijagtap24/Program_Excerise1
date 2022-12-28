using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.ListExample
{
    public enum ProductType { furniture, mobile, mensshirt }
    public class Product
    {
        public string Company { set; get; }
        public ProductType ProductType;
        public List<DetailsProduct> dlist = new List<DetailsProduct>();
    }
    public class DetailsProduct
    {
        public string ProductName { set; get; }
        public string Colour { set; get; }
        public int ProductPrice { set; get; }



    }
    class Productdetails
    {
        static void Main(string[] args)
        {
            List<Product> plist = new List<Product>()
            {
                new Product
                {
                   Company = "Sk Chair and Furniture",
                   ProductType = ProductType.furniture,
                    dlist =
                    {
                        new DetailsProduct { ProductName="office Chair" , Colour = "black", ProductPrice =10000},
                        new DetailsProduct { ProductName="Sofa" , Colour = "blue", ProductPrice =350000},
                        new DetailsProduct { ProductName="Diningtable" , Colour = "gray ", ProductPrice =100000},
                    }
                },
                new Product
                {
                    Company = "Mobile shop ",
                    ProductType = ProductType.mobile,
                    dlist =
                    {
                        new DetailsProduct{ProductName = "sumsung mobile ",Colour= "black", ProductPrice =25000}
                    }

                },
                new Product
                {
                     Company = "Mens shirts shop ",
                    ProductType = ProductType.mensshirt,
                    dlist =
                    {
                        new DetailsProduct{ProductName = "huddy ",Colour= "black", ProductPrice =5000}
                    }
                }

            };
            foreach(Product p in plist)
            {
                Console.WriteLine("***************");
                Console.WriteLine($"company = {p.Company} --> product type = { p.ProductType}");
                foreach(DetailsProduct d in p.dlist)
                {
                    Console.WriteLine($"name = {d.ProductName} -  colour  {d.Colour} - price =  {d.ProductPrice}");
                }
            }
            Console.ReadLine();
        }
    }
}
