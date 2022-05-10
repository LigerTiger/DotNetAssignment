using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_I
    {
        public static void Main()
        {
            
            string input = "The quick brown Fox jumps over the lazy Dog";

            string result2 = input.Replace("The", "A");
            Console.WriteLine("Before Repalace: \n" + input);
            Console.WriteLine("After Reaplace: \n"+result2);
            Console.ReadLine();
        }
    }
}
