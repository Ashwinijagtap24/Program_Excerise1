using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork
{
    class BookDetails
    {
      /*  int Book_id;
        string Book_name;
        string Book_author;
        int Price;*/
        public int Book_id
        {
            get;
            set;
        }
        public string Book_name
        {
            get;
            set;
        }
        public string Book_author
        {
            get;
            set;

        }
        public int Price
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            BookDetails b = new BookDetails();
            b.Book_id = 202;
            b.Book_name = "Believe in Yourself";
            b.Book_author = " Joseph Murphy";
            b.Price = 285;
            Console.WriteLine(" Book Id =  "+b.Book_id+ "\n Book Name = "+b.Book_name+ "\n Book Author ="+b.Book_author+ " \n Book price ="+b.Price);
            Console.ReadLine();
        }
    }
}
