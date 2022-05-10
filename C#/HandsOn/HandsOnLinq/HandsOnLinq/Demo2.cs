using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo2
    {
        static void Main(string[] args)
        {
            int[] no = { 23, 34, 54, 67, 78, 76, 54, 43, 32, 21 };
            // GET FIRST IN THE SEQUENCE 
            var result = no.First();
            Console.WriteLine(result);
            // GET LAST IN THE SEQUENCE
            result = no.Last();
            Console.WriteLine(result);
            //GET FIRST EVEN VALUE IN THE SEQUESNCE
            result = no.First(n => n % 2 == 0);
            Console.WriteLine(result);
            //GET LAST EVEN VALUE IN THE SEQUESNCE
            result = no.Last(n => n % 2 == 0);
            Console.WriteLine(result);
            //AGREGATE FUNCTIONS
            // SUM OF ARRAY VALUES
            result = no.Sum();
            Console.WriteLine(result);
            //AVERAGE VALUES
            result = (int)no.Average(); //CONVERT DOUBLE TO INT
            //GET MAX VALUE
            result = no.Max();
            Console.WriteLine(result);
            //GET MINIMUM VALUE
            result = no.Min();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
