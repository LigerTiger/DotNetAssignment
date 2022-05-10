using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment_23_04
{
    class ArrayQ_02
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of arrays");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Ener the array values: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Element are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + a[i]);
            }

            Console.ReadKey();
        }
    }
}
