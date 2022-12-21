using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.HomeWork.ListExample
{
    public enum BookLibraries {ComedyBook,HerrorBook,DramaBook }
    public class Book
    {
        public string BookName { set; get; }
        public int BookPrice { set; get; }
        public BookLibraries bookLibraries;
        public List<BookDetails> booklist = new List<BookDetails>();
    }
    public class BookDetails
    {
        
        public string Author { set; get; }
        
    }
    public class MainBookDetails
    {
        static void Main(string[] args)
        {
            List<Book> blist = new List<Book>()
            {
                new Book
                {
                    BookName = "Tom Clancy Red Winter ",
                    BookPrice=2500,
                    bookLibraries = BookLibraries.ComedyBook,
                    booklist = { new BookDetails {Author = " Marc" }, }

                },
                new Book
                {
                    BookName = "Gost Story",
                    BookPrice =20000,
                    bookLibraries =BookLibraries.HerrorBook,
                    booklist ={new BookDetails { Author="Petter"} }
                },
                new Book
                {
                    BookName="Romeo And juliet",
                    BookPrice = 25000,
                    bookLibraries =BookLibraries.DramaBook,
                    booklist = {new BookDetails { Author = "William Shakespear"} }
                }
            };
            foreach(Book items in blist)
            {
                Console.WriteLine($"{items.BookName} -> {items.BookPrice} -> {items.bookLibraries}");
                foreach(BookDetails b in items.booklist)
                {
                    Console.WriteLine("\tAuthor name = " +b.Author);
                }
            }
            Console.ReadLine();

        }
    }
}
