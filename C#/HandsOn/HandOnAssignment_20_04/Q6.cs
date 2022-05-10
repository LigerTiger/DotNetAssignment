using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q6
    {
        static void Main(string[] args)
        {
           
            
            double f, c = 0.0;
            Console.WriteLine("Enter Fahrenheit value");
            f = Convert.ToDouble(Console.ReadLine());


            c = (f- 32) / 1.8;

            Console.WriteLine("value of temperature in celsius:"+c);
            Console.ReadKey();
        }

    }

}
