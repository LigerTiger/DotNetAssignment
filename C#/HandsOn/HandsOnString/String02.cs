using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class String02
    {
        static void Main()
        {
            string str = ".Net was developed by Microsoft_team";
            string[] s = str.Split(' ','_');
            foreach (string k in s)
                Console.WriteLine(k);
            string value = "     abc      ";
            Console.WriteLine(value.TrimStart());
            Console.WriteLine(value.Trim());
           


        }
    }
}
