using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class String06
    {
        static void Main()
        {
            Console.WriteLine(string.Format("{0:F2}", 12.34345455445));
            Console.WriteLine(string.Format("{0:C}", 1232932));
            
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(string.Format("{0:D}", DateTime.Now)); //display only Date in long format
            Console.WriteLine(string.Format("{0:d}", DateTime.Now)); //display one Dae in small format
            Console.WriteLine(string.Format("{0:T}", DateTime.Now)); //display time in long format
            Console.WriteLine(string.Format("{0:t}", DateTime.Now)); //displ;ay time in small format
            Console.ReadKey();
        }
    }
}
