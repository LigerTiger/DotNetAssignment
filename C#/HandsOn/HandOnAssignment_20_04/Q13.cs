using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q13
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0;
            for (int i = 201; i <300; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            //Console.WriteLine("The Sum of the number between 200 to 300 which are divisible by 7 is: " + sum);
            Console.WriteLine("Total numbers between 200 to 300 which are divisible by 7 is: " + count);
            Console.ReadKey();
        }
    }

}
