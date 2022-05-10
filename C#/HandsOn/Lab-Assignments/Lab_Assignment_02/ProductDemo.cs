using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_02
{



    class ProductDemo
    {
        private object id;
        private object name;
        private object price;
        private object quantity;


        public ProductDemo() { }


        public ProductDemo(int id, string name, double price, int quantity)
        {

            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void DisplayProductDetails()
        {

            double amtPayable = (double)price * (int)quantity;
            Console.WriteLine("Product Details: ");
            Console.WriteLine("Product id: {0}", id);
            Console.WriteLine("Product name: {0}", name);
            Console.WriteLine("Product Price: {0}", price);
            Console.WriteLine("Product Quantity: {0}", quantity);
            Console.WriteLine("Product Amt Payable: {0}", amtPayable.ToString("N"));
        }
        static void Main(string[] args)
        {


            Console.Write("Enter the id of product: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of product: ");
            string name = Console.ReadLine();
            Console.Write("Enter the price of product: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter the quantity of product: ");
            int quantity = int.Parse(Console.ReadLine());
            ProductDemo productDemo = new ProductDemo(id, name, price, quantity);
            productDemo.DisplayProductDetails();


            Console.ReadLine();


        }
    }

        
        
    

}
