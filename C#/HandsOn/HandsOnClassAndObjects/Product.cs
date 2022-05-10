using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Product
    {
        public int  productId;
        public string productName;
        public string description;
        public double price;

        // METHOD //
        public void Deatails()
        {
            Console.WriteLine("Id: "+productId);
            Console.WriteLine("Name: "+productId);
            Console.WriteLine("Description: "+description);
            Console.WriteLine("Price:"+price);
        }
    }
    class Test_Product
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.productId = 325410;
            p1.productName = "Keyboard";
            p1.description = "computer Accessories ";
            p1.price=450;
            p1.Deatails();

            Product p2 = new Product();
            p2.productId = 31054;
            p2.productName = "Wireless Speaklers";
            p2.description = "Music Systems ";
            p2.price = 12450;
            p2.Deatails();
            Console.ReadKey();
        }
    }
}
