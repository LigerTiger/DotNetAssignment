using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookServices
{
    public class BookService
    {
        public int bookNo;
        public string bookName;
        public int bookPrice;
        public DateTime releaseDate;
        public string author;
        public void BookDetails()
        {
            Console.WriteLine("Book Number is : " + bookNo);
            Console.WriteLine("Book Name is : " + bookName);
            Console.WriteLine("Book Price is : " + bookPrice);
            Console.WriteLine("Book Release date is : " + releaseDate);
            Console.WriteLine("Book Author is : " + author);
        }

    }
  
}
