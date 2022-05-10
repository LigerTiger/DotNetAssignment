using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_E
    {
        static void Main(string[] args)
        {
            string str1 = "The quick brown Fox jumps over the lazy Dog";
            string str2 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            if (str1 == str2)
            {
                Console.WriteLine("String are equal");
            }
            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("String area equal");
            }
            if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
            {
                Console.WriteLine("String are equal");
            }

            Console.ReadKey();
        }
    }
}
