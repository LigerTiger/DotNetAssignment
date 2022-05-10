using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_D
    {
        static void Main(string[] args)
        {
            //The quick brown fox jumps over the lazy dog
            string[] str = { "The", "quick", "brown",
                           "fox", "jumps","over", "the", "lazy","dog."};
            foreach (var value in str)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("it String ind with ",value, endsInPeriod);
            }
            Console.ReadKey();
        }
    }
}
