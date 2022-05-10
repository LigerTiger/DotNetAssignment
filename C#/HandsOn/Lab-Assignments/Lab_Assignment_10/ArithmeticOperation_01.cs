using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_10
{
    class ArithmeticOperation_01

    {
        private delegate double Operation(double num1, double num2);


        private static void Main(string[] args)
        {
            Console.Write("Input number 1: ");
            var num1 = double.Parse(Console.ReadLine());


            Console.Write("Input number 2: ");
            var num2 = double.Parse(Console.ReadLine());


            Console.Write("Input operation (+,*,/,- or max): ");
            var op = Console.ReadLine().Trim();


            Operation operation;
            switch (op)
            {
                case "+":
                    operation = ArithmeticOperation.AddNumbers;
                    break;


                case "*":
                    operation = ArithmeticOperation.MultiplyNumbers;
                    break;


                case "/":
                    operation = ArithmeticOperation.DivideNumbers;
                    break;


                case "-":
                    operation = ArithmeticOperation.SubtractNumbers;
                    break;


                case "max":
                    operation = ArithmeticOperation.FindMaxNumber;
                    break;


                default:
                    Console.WriteLine("Error: operation is no supported");
                    return;
            }


            var result = operation(num1, num2);
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }


    public class ArithmeticOperation
    {
        public static double AddNumbers(double num1, double num2) // =>num1 + num2
        {
            return num1 + num2;
        }


        public static double MultiplyNumbers(double num1, double num2) //=> num1 * num2;
        {
            return num1 * num2;
        }

        public static double DivideNumbers(double num1, double num2) //  => num1 / num2;
        {
            return num1 / num2;
        }

        public static double SubtractNumbers(double num1, double num2) //=> num1 - num2;
        {
            return num1 - num2;
        }

        public static double FindMaxNumber(double num1, double num2) => num1 >= num2 ? num1 : num2;

    }
}

