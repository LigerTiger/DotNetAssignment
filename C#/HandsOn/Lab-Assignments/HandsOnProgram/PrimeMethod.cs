using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgram
{
    class PrimeMethod
    {
        static int count=1;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Pmethod(n);
            Console.ReadLine();


        }
        public static void Pmethod(int n)
        {
            for(int i=1;i<=n/2;i++)
            {
                if (n % i == 0)
                {
                    if (n % i == 0)
                        count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number ");

            }
            else
            {
                Console.WriteLine("Not A prime number ");  
            }
            
        }
    }
}
