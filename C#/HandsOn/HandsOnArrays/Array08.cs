using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array08
    {
        static void Main()
        {
            //jagged array
            int[][] ja = new int[3][];
            ja[0] = new int[] { 12, 34, 56, 78, 89 };
            ja[1] = new int[] { 45, 67, 8 };
            ja[2] = new int[] { 45, 67, 8, 90 };
            //fetch 1 st array values
            //for(int i=0;i<ja[0].Length;i++)
            //{
            //    Console.Write(ja[0][i]+" ");
            //}
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < ja[r].Length; i++)
                {
                    Console.Write(ja[r][i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
