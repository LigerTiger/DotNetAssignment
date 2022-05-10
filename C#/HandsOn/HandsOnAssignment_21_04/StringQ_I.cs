using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class StringQ_I
    {
        public static void Main()
        {
            
            string str = "The quick brown Fox jumps over the lazy Dog";

            string result = str.Replace("The", "A");
            Console.WriteLine("Before Repalace: \n" + str);
            Console.WriteLine("After Reaplace: \n"+result);
            Console.ReadLine();
        }
    }
}
