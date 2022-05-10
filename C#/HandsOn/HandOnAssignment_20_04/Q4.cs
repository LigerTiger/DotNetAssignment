using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers: ");
            int n =Convert.ToInt32(Console.ReadLine());


            if(n%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadKey();
        }
    }
}
