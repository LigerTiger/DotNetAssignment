using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ElementAtAndElementAtOrDefault
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("ElementAt");
            var query = numbers.ElementAt(4);
            Console.WriteLine(4);
            Console.WriteLine("ElementAtOrDefault");
            int[] numbers1 = {1, 2, 3, 4, 5, 6, 7, 8,9 };
            var query1 = numbers1.ElementAtOrDefault(9);
            Console.WriteLine(query1);
            Console.ReadKey();
        }
    }
}
