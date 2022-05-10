using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class String04
    {
        static void Main()
        {
            string s = "GoodMorning Users";
            string s1=s.Replace('o', 'O');
            string s2 = s.Replace("GoodMorning","GoodNight");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
