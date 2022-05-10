using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_M
    {
        static void Main(string[] args)
        {

            string str = "The quick brown fox jumps over the lazy dog";

            string lowerCase = str.ToUpper();

            Console.WriteLine($"Original string: {str}");
            Console.WriteLine($"In uppercase:    {lowerCase}");
            Console.ReadKey();
        }
    }
}
