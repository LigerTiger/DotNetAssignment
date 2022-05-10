using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_07
{
    class ProductTest
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("1. Adding New Product");
                Console.WriteLine("2. Deleting Currently Searched Product");
                Console.WriteLine("3. Searching Product");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Product newProduct = new Product();
                            Console.Write("Enter the Product No: ");
                            newProduct.ProductNo = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Product Name: ");
                            newProduct.Name = Console.ReadLine();
                            Console.Write("Enter the Product Rate: ");
                            newProduct.Rate = double.Parse(Console.ReadLine());
                            Console.Write("Enter the Product Stock: ");
                            newProduct.Stock = int.Parse(Console.ReadLine());
                            products.Add(newProduct);
                            //SORT PRODUCTS
                            products.Sort(delegate (Product x, Product y)
                            {
                                return x.ProductNo.CompareTo(y.ProductNo);
                            });
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter the Product No to delete: ");
                            int productNo = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Product p in products)
                            {
                                if (p.ProductNo == productNo)
                                {
                                    products.Remove(p);
                                    exist = true;
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe product does not exist!\n");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter the Product No to search: ");
                            int productNo = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Product p in products)
                            {
                                if (p.ProductNo == productNo)
                                {
                                    Console.WriteLine(p.ToString());
                                    exist = true;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe product does not exist!\n");
                            }
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }

            Console.ReadKey();
        }

    }
}