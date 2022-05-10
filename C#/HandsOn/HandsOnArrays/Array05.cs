using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array05
    {
        static void Main(string[] args)
        {
            int[] a= {12, 3, 54, 34, 65, 45, 76, 67, 87, 89, 90 }; 
            Console.WriteLine("Array Size: {0}", a.Length); 
            Console.WriteLine("Rank: " + a.Rank); //return dimension of the array


            //sort array elements

            Array.Sort(a); ////revrese array elements

                // Array.Reverse(a);
            foreach (int k in a)
                Console.WriteLine(k);
            int[] b = new int[3];
            Array.Copy(a, b, 3);

            Console.WriteLine();
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter no");

            int no = Convert.ToInt32(Console.ReadLine());

            int indx = Array.BinarySearch(a, no);

            Console.WriteLine(indx);

            if (indx >= 0)
                Console.WriteLine("Valid no");
            else
                Console.WriteLine("InValid no");
            Console.ReadKey();
        }
    }
}
