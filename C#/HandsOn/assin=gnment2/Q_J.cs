using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_J
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string[] after_split = str.Split();
            Console.WriteLine();
            Console.WriteLine("String after split ");
            foreach (string str1 in after_split)
            {
                Console.WriteLine(str1);
            }
            Console.ReadKey();

        }
    }
}
