using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgram
{
    class RevMethod
    {
        static int rev = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the iputs: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Rev(n);
            Console.ReadLine();
        }
    
        public static void Rev(int n)
        {
            while (n > 0)
            {
                int mod = n % 10;
                rev = ((rev * 10) + mod);
                n = (n / 10);
            }
            Console.WriteLine($"Reverse the numbers are : {rev} ");

        }
    }
}
