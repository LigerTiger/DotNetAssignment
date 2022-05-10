using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class String05
    {
        static void Main()
        {
            StringBuilder obj = new StringBuilder(); //mutable srrings(value can be change)
            obj.Append("Hello");
            obj.Append(" User");
            Console.WriteLine(obj);
            obj.Replace("Hello", "GoodMorning");
            Console.WriteLine(obj);
            StringBuilder s1 = new StringBuilder("Goodmorning Students");
            s1.Insert(0, "Hi ");
            Console.WriteLine(s1);
            string s2 = "Hello User"; //strings are immutable(value can not be chage dynamically)
            s2.Replace("User", "GoodMorning");
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
