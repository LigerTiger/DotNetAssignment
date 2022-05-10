using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class FirstOrDefaultAndLastOrDefault
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            var query = numbers.FirstOrDefault(n => n % 2 == 0);
            Console.WriteLine("This is even element in the sequesnce");
            Console.WriteLine(query);
            Console.WriteLine("This last odd elements in the sequence");
            query = numbers.LastOrDefault(n => n %2 == 1);
            Console.WriteLine(query);

            Console.ReadKey();
        }
    }
}
