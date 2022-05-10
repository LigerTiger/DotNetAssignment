using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array02
    {
        static void Main()
        {
            Console.WriteLine("Enter Array size");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //read array value from input
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter a[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            //print array valuies
            foreach (int k in a)
                Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}
