using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q12
    {
        static void Main(string[] args)
        {

            int i, j;
           Console.WriteLine("Enter number:");
           int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i<=n; i++)
            {
                Console.WriteLine("Multiplication Table of "+i+": ");
                for(j=1;j<=10;j++)
                    Console.WriteLine("{0}X{1}={2}", i, j, i*j);
            }
            Console.ReadKey();
        }
    }
}
