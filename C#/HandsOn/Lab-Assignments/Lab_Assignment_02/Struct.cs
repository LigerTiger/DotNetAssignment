using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_02
{
    struct MyStruct
    {
        public int number;


        public void displaySquare()
        {
            Console.WriteLine("The square of the number is: " + this.number * this.number);
        }
        public void displayCube()
        {
            Console.WriteLine("The cube of the number is: " + this.number * this.number * this.number);
        }
    }
    class Test_Product
    {
    
            static void Main(string[] args)
            {
                bool loop = true;
                int option = 0;
                MyStruct myNumber = new MyStruct();


                Console.WriteLine("Enter your number: ");
                myNumber.number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display square of the number");
                Console.WriteLine("2. Display cube of the number");
                Console.WriteLine("3. Exit");


                while (loop)
                {
                    Console.Write("\r\nSelect an option: ");
                    option = Convert.ToInt32(Console.ReadLine());


                    if (option < 1 || option > 3)
                    {
                        Console.WriteLine("Error: You entered a wrong number, please try again!");
                    }
                    if (option == 1)
                    {
                        myNumber.displaySquare();
                    }
                    else if (option == 2)
                    {
                        myNumber.displayCube();
                    }
                    else if (option == 3)
                    {
                        loop = false;
                    }
                }
            }
        
    }
    
}
