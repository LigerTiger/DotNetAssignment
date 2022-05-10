using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Some Integer Input: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You Entered One ");
                        break;

                    case 2:
                        Console.WriteLine("You Entered Two ");
                        break;

                    case 3:
                        Console.WriteLine("You Entered  Three");
                        break;

                    case 4:
                        Console.WriteLine("You Entered Four ");
                        break;

                    case 5:
                        Console.WriteLine("You Entered Five ");
                        break;
                    default:
                        Console.WriteLine("Error: The Entered  number was not expected ");
                        break;
                
                }
            }
            else
                Console.WriteLine("Error: The Entered values is not an Integer number!!! ");
            Console.ReadKey();

        }
    }
}
