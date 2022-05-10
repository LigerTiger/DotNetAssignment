

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_K
    {
        static void Main(string[] args)
        {
            string s = "The quick brown Fox jumps over the lazy Dog";

            string[] sParts = s.Split();
            Console.WriteLine("Sepearate String ");
            foreach (string sPart in sParts)
            {
               
                Console.WriteLine(sPart);
            }
            Console.ReadKey();

        }
    }
}
