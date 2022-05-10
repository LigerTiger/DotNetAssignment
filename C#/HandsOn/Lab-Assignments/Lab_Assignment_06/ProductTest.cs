using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_06
{
    class ProductTest
    {
        static void Main(string[] args)
        {
            try
            {
                int id;
                string name;
                double price;
                ProductMock pm = new ProductMock();


                Console.Write("Enter Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Price: ");
                price = double.Parse(Console.ReadLine());


                pm.ProductId = id;
                pm.ProductName = name;
                pm.Price = price;
            }
            catch (DataEntryException ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            Console.ReadKey();


        }
    }
}
