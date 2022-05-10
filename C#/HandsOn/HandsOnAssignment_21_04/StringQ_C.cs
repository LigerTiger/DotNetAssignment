using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class StringQ_C
    {
        static void Main(string[] args)
        {
            string str1 = "The quick brown Fox jumps over the lazy Dog";
            string str2 = " and killed it";
            string str3= string.Concat(str1, str2);
            Console.WriteLine("After adding  String ");
            Console.WriteLine(str3);
            Console.ReadLine();

        }
    }
}
