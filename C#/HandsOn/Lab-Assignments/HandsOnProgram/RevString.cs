using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgram
{
    class RevString
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the input: ");
            string str = Console.ReadLine();
            string rev = string.Empty;
            int len = str.Length - 1;
            while(len>=0)
            {
                rev = rev + str[len];
                len--;
            }
            Console.WriteLine($"Reverse the string is: {rev} ");
            Console.ReadKey();
        }
    }
}
