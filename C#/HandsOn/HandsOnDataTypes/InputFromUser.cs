using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDataTypes
{
    class InputFromUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome ");
            Console.WriteLine(name);
            Console.WriteLine("Thank You");
            Console.ReadKey();

        }
    }
}
