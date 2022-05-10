using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_02
{
    class City
    {
        static void Main(string[] args)
        {
            int numberCities;
            Console.Write("Enter the number of city: ");
            numberCities = Convert.ToInt32(Console.ReadLine());
            // DEFINE A SINGLE DIMENSIONAL ARRAY OF STRING TO HOLD THE NAME OF CITY.
           
            string[] cites = new string[numberCities];
            // ACCEPT SOME VALUE FROM THE USER AND STORE THEM IN THE ARRAY.
           
            for (int i = 0; i < numberCities; i++)
            {
                Console.Write("Enter a city {0}: ", (i + 1));
                cites[i] = Console.ReadLine();
            }
             // PRINT ALL THE DATA OF THE ARRAY
            
            Console.WriteLine("\nAll cities are:");
            foreach (var c in cites)
            {
                Console.WriteLine(c);
            }


            Console.ReadKey();
        }
    }
}
