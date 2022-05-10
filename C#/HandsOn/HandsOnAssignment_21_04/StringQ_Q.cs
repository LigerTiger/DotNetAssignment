using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class StringQ_Q
    {
        static void Main(string[] args)
        {
            string str1 = "I WANDER'D lonely as a cloud\n";
            string str2 = "That floats on high o'er vales and hills,\n";
            string str3 = "When all at once I saw a crowd,\n";
            string str4 = "A host, of golden daffodils;";
            string str5 = " \bBeside the lake, beneath the trees,\n";
            string str6 = "Fluttering and dancing in the breeze.";
            string str7 = string.Concat(str1, str2, str3, str4, str5, str6);
            Console.WriteLine(str7);
            Console.ReadKey();
        }
    }
}
