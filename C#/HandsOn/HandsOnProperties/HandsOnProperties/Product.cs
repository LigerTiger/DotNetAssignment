using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    class Product
    {
        private int productId;
        private string productName;
        private double price;

        public Product(int productId, string productName, double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        // READ ONLY PROPERTIES

        public int ID
        {
            get { return productId; }
        }
        public string NAME
        {
            get { return productName; }
        }
        public double PRICE
        {
            get { return price; }
        }
    }
    class Test_Product
    {
        static void Main()
        {
            Product p = new Product(101, "Keyboard", 600);
            Console.WriteLine($"ID: {p.ID} Name: {p.NAME} Price:{p.PRICE}");
        }
    }
}
