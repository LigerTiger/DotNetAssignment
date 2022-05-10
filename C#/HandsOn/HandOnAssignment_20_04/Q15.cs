using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q15
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            Console.WriteLine("Enter the three Values: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            int small = num1;
            if (small > num2)
                small = num2;
            if (small > num3)
                small = num3;
            if (small > num4) 
                small = num4;
            if (small > num5)
                small = num5;
            Console.WriteLine("Smallest Values : "+small);
            Console.ReadKey();
        }
    }
}
