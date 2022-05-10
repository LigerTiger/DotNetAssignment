using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class ProductRepository
    {
        Product[] products = new Product[5];
        int idx = 0;
        public void AddProduct(Product product)
        {
            
            if (idx < products.Length)
            {
                products[idx] = product;
                idx++;
            }
            else
            {
                Console.WriteLine("Class is Full");
            }
        }
        public Product GetProductById(int productId) 
        {
            foreach(var product in products)
            {
                if(product != null)
                if(product.productId == productId)
                {
                            return product;
                }
            }
            return null; 

        }
        public Product[] GetAllProducts() 
        {
            return products;
        }
        public void EditProduct(int productId,string pname,int price, int stock) 
        {
            for(int i=0;i< products.Length;i++)
            {
                if(products[i].productId == productId)
                {
                    products[i].productName = pname;
                    products[i].productPrice = price;
                    products[i].productPrice = stock;
                    break; 
                }
            }
        }
        public void DeleteProduct(int productId)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].productId == productId)
                {
                    products[i] = null;
                    break; 
                }
            }
        }
        public static void Main()
        {
            ProductRepository repository = new ProductRepository();
            do
            {
                Console.WriteLine("1.AddProduct");
                Console.WriteLine("2.GetProductById");
                Console.WriteLine("3.GetAllProducts");
                Console.WriteLine("4.EditProduct");
                Console.WriteLine("5.DeleteProduct");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Product product = new Product();
                        Console.WriteLine("Enter Product Name");
                        product.productName = Console.ReadLine();
                       

                        Random random = new Random();
                        product.productId = random.Next(1000);
                        Console.WriteLine("Enter Price");
                        product.productPrice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Stock");
                        product.productStock = Convert.ToInt32(Console.ReadLine()); ;
                        repository.AddProduct(product);
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Product Id");
                            int productId = int.Parse(Console.ReadLine());
                            Product p =repository.GetProductById(productId);
                            if(p!=null)
                            {
                                
                                p.Details();
                            }
                            else
                            {
                                Console.WriteLine("Invalid ProductId");
                            }
                        }
                        break;
                    case 3:
                        {
                            Product []products=repository.GetAllProducts();
                            foreach(Product p in products)
                            {
                                if(p!=null) 
                                p.Details();
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter product Id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter product  Name");
                            string pname = Console.ReadLine();
                            Console.WriteLine("Enter Product Price");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Product stock");
                            int stock = int.Parse(Console.ReadLine());
                            repository.EditProduct(id, pname, price, stock);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = int.Parse(Console.ReadLine());
                            repository.DeleteProduct(id);
                        }
                        break;
                    case 6:
                        {
                            Environment.Exit(0); 
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            } while (true);
            
           
        }

    }
}
