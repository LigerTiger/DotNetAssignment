using System;

namespace HandsOnClassAndObjects
{


    class Product
    {

        public int productId;
        public string productName;
        public int productPrice;
        public int productStock;

        public void Details()
        {
            Console.WriteLine($"ID:{productId} Name:{productName} Price:{productPrice} Stock: {productStock}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product();
            p1.productId = 321;
            p1.productName = "Samsung Mobile";
            p1.productPrice = 24000;
            p1.productStock = 100;

            p1.Details();
            Product p2 = new Product();
            p2.productId = 123;
            p2.productName = "FastTrack";
            p2.productPrice = 1500;
            p2.productStock = 150;

            p2.Details();
            Product p3 = new Product();
            Console.WriteLine("Enter ProductName");
            p3.productName = Console.ReadLine();
            p3.productId = 1234;
            p3.productPrice = 1300;
            p3.productStock = 450;
            Console.WriteLine("Enter Enter Product ID ");
            p3.productPrice = Convert.ToInt32(Console.ReadLine());
            p3.Details();
            Product p4 = new Product() { productId = 3240834, productName = "Boat Speaker", productPrice = 4000 };
            Product[] products = new Product[5];
            products[0] = p1;
            products[1] = p2;
            products[2] = p3;
            products[3] = new Product();
            products[3].productId = 12345;
            products[3].productName = "Apple Watch";
            products[3].productPrice = 45000;
            products[3].productStock = 90;

            Console.WriteLine();
            foreach (var item in products)
            {
                if (item != null)
                    item.Details();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}
