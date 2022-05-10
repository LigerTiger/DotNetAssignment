using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q11
    {
        public static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter the number ");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                sum += x * x * x;
            } 
            
            Console.WriteLine(sum);
            Console.WriteLine(n);
            Console.ReadKey();


        }
    }
}
