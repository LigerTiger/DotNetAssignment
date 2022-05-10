using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q16
    {
        static void Main(string[] args)
        {
            int Avg, Total, M1, M2, M3, M4, M5, M6, M7, M8, M9, M10 ;
            Console.WriteLine("Enter the marks of the subjects");

            M1 = Convert.ToInt32(Console.ReadLine());
            M2 = Convert.ToInt32(Console.ReadLine());
            M3 = Convert.ToInt32(Console.ReadLine());
            M4 = Convert.ToInt32(Console.ReadLine());
            M5 = Convert.ToInt32(Console.ReadLine());
            M6 = Convert.ToInt32(Console.ReadLine());
            M7 = Convert.ToInt32(Console.ReadLine());
            M8 = Convert.ToInt32(Console.ReadLine());
            M9 = Convert.ToInt32(Console.ReadLine());
            M10 = Convert.ToInt32(Console.ReadLine());
            Total = M1 + M2 + M3 + M4 + M5 + M6 + M7 + M8 + M9 + M10;
            Avg = Total / 10;
            Console.WriteLine("Tolat marks of ten subjects is {0}", Total);
            Console.WriteLine("Average marks of ten subjects is {0}", Avg);

            Console.ReadKey();
        }
        
    }
    
}
