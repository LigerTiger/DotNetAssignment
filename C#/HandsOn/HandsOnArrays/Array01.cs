using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array01
    {
        static void Main(string[] args)
        {
            //delcartion of array
            int[] a = new int[5];
            //assign values
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;
            // a[5] = 60; //exception
            //access value from an array
            int k = a[2];
            //access all values from an array
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            //fetch all values using foreach
            foreach (int i in a)
            {
                Console.Write(i + " ");

            }
            Console.ReadKey();

        }
    }
}
