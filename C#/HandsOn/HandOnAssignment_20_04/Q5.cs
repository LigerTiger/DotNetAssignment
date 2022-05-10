using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the nuumber: ");
            int n =Convert.ToInt32(Console.ReadLine());
            int EvenCount = 0;
            int OddCount = 0;
            while (n>0)
            {
                int rem = n % 10;
                if(rem%2==0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
                n = n / 10;
            }
            Console.WriteLine("Even number Count = "+EvenCount);
            Console.WriteLine("Odd number Count = "+OddCount);
            Console.ReadKey();
        }
    }
}
