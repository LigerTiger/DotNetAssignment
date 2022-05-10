using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class String01
    {
        static void Main()
        {
            string s = "Hi";
            string s1 = "Students";
            string s2 = "Good Morning";
            string s3 = string.Concat(s, s1, s2);
            s3 = s + s1 + s2;
            Console.WriteLine(s3);
            string[] a = { "Hi", "Students", "Good Morning" };
            string ss = string.Join(" ", a);
            Console.WriteLine(ss);
            Console.ReadKey();

        }
    }
}
