using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q14
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the three Values: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest: "+num1);
                }
                else
                {
                    Console.Write("Number three is the largest: "+num3);
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest: "+num2);
            else
                Console.Write("Number three is the largest: " + num3);
            Console.ReadLine();
        }
        
    }
}
