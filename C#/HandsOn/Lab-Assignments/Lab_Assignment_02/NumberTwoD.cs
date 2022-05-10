using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_02
{
    class Number
    {
        static void Main(string[] args)
        {
            //A TWO DIMENTIONAL ARRAY OF NUMBER TO STORE 5 ROWS AND 6 COLUMN.
            int[,] numbers = new int[5, 6];
            //WRITE A CODE TO ACCEPT DATA, ASSIGN IT IN ARRAY
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Enter value [{0}][{1}]: ", i, j);
                    int.TryParse(Console.ReadLine(), out numbers[i, j]);
                }
            }
            // PRINT THE DATA ENTERD BY THE USER. //
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0,5} ", numbers[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
