using System;
using System.Linq;

namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 23, 34, 54, 67, 78, 76, 54, 43, 32, 21 };
            // FETCH EVEN VALUE FROM THE ARRAY USING LINQ
            var o = from k in x
                     where k % 2 == 0
                     select k;
            foreach(var item in o)
                Console.WriteLine(item);
        }
    }
}
