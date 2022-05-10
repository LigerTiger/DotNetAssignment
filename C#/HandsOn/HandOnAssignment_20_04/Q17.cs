using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnAssignment_20_04
{
    class Q17
    {
        static void Main(string[] args)
        {
            string str; 
            int l = 0;

            
            Console.Write("Enter the String : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.WriteLine("Length of the string is : {0}", l);
            Console.ReadKey();
        }
        
    }
}
