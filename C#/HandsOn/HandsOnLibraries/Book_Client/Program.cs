using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookServices;
namespace Book_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            BookService b = new BookService();
            Console.Write("Enter Book Number : ");
            b.bookNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Name : ");
            b.bookName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Book Price : ");
            b.bookPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Release Date : ");
            b.releaseDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Book Author : ");
            b.author = Convert.ToString(Console.ReadLine());
            b.BookDetails();
            Console.ReadKey();
        }
    }
}
