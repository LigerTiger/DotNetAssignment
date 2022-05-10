using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array04
    {
        static void Main()
        {
            string[] garden = {"Rose",
            "Lilly",
            "Tulips",
            "Jasmine"
            };
            Console.WriteLine("Enter name of the Flower");
            string name = Console.ReadLine();
            bool flag = false;
            foreach (string s in garden)
            {
                if (s == name)
                {
                    Console.WriteLine("Flower is in the Garden");
                    flag = true;
                    break;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("FLower not in the Garden");
            }
            Console.ReadKey();
        }
    }
}
