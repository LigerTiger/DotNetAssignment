using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array09
    {
        static void Main()
        {
            //Jagged array with elements of 2 dimentsional array 
            int[][,] ja = new int[2][,];
            ja[1] = new int[2, 2] { { 10, 2 }, { 11, 3 } };
            ja[0] = new int[2, 1] { { 10 }, { 20 } };

        }
    }
}
