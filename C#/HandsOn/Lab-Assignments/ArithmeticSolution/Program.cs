using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmeticOperation;

namespace ArithmeticSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = "";
            Calculator calc = new Calculator();
            while (!ch.Equals("5"))
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Square");
                Console.WriteLine("6. Exit");
                Console.Write("Select the operation: ");
                ch = Console.ReadLine();
                int number1 = 0;
                int  number2 = 0;
                if (ch.Equals("1") || ch.Equals("2") || ch.Equals("3") ||
                    ch.Equals("4") || ch.Equals("5"))
                {
                    Console.Write("Enter the first number: ");
                    number1 =int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    number2 = int.Parse(Console.ReadLine());
                }
                if (ch.Equals("1"))
                {

                    Console.WriteLine("{0} + {1} = {2}", number1, number2, calc.Add(number1, number2));
                }
                else if (ch.Equals("2"))
                {
                    Console.WriteLine("{0} - {1} = {2}", number1, number2, calc.Subtract(number1, number2));
                }
                else if (ch.Equals("3"))
                {
                    Console.WriteLine("{0} * {1} = {2}", number1, number2, calc.Multiply(number1, number2));
                }
                else if (ch.Equals("4"))
                {
                    Console.WriteLine("{0} / {1} = {2}", number1, number2, calc.Division(number1, number2));
                }
                else if (ch.Equals("5"))
                {
                    Console.WriteLine("{0} ^ {1} = {2}", number1, number2, calc.Square(number1));
                }
                else if (ch.Equals("6"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nSelect correct menu item.\n");
                }
            }
            Console.ReadKey();
        }
    }
    
}
