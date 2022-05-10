using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q18
    {
        static void Main(string[] args)
        {
            string str,rev;
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            rev = "";
            Console.WriteLine("String is {0}", str);
            int len;
            len = str.Length - 1;
            while(len>=0)
            {
                rev = rev + str[len];
                len--;
            }
            Console.WriteLine("Reverse String is {0} : ", rev);
            Console.ReadKey();


        }
    }
}
