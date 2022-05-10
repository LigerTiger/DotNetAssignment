using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q8
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("Enter the range of number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                Console.WriteLine(i * i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
