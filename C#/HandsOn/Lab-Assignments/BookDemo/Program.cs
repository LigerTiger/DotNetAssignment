using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo
{
    class BooksDemo

    {
        private string[] colName = { "BookTitle", "Author", "Publisher", "Price" };
        private string[,] bookDetails = new string[2, 4];
       
        public BooksDemo()
        {

        }
      
        public void ReadBooks()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < colName.Length; i++)
                {
                    Console.Write("Enter {0}: ", colName[i]);
                    bookDetails[j, i] = Console.ReadLine();
                }
                Console.Write("\n");
            }
        }
       
        public void DisplayBooks()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < colName.Length; i++)
                {
                    Console.Write("{0}: {1}\n", colName[i], bookDetails[j, i]);
                }
                Console.Write("\n");


            }
        }


        static void Main(string[] args)
        {
            BooksDemo booksDemo = new BooksDemo();
            booksDemo.ReadBooks();
            booksDemo.DisplayBooks(); ;

            Console.ReadKey();
        }


    }
}
