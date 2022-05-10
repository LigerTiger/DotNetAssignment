using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgram
{
    class SumOfDigitsCube
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            DigitsCube(num);
            Console.ReadLine();


        }
        public static void DigitsCube(int num)
        {
           while(num>0)
           {
                int mod = num % 10;
                sum=sum+(int)Math.Pow(mod,3);
                num = num / 10;
           }
            Console.WriteLine($"Output: Sum of Each digits cubes: {sum}");
            
        }

    }
}
