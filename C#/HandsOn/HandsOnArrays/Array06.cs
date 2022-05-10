using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array06
    {
        static void Main()
        {
            int[,] n = new int[2, 3];
            Console.WriteLine("Rank: " + n.Rank); //2
            //assign values
            //1st row
            n[0, 0] = 10;
            n[0, 2] = 20;
            n[0, 1] = 30;
            //2nd row
            n[1, 0] = 40;
            n[1, 1] = 50;
            n[1, 2] = 60;

            int k1 = n[1, 1];
            foreach (int k in n)
                Console.WriteLine(k);
            Console.WriteLine();
            //display array values in matrix format
            for (int i = 0; i < 2; i++) //i is row index
            {
                for (int j = 0; j < 3; j++) //j is column index
                {
                    Console.Write(n[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
