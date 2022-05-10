using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class StringQ_H
    {
        static void Main(string[] args)
        {
            string str1 = "The quick brown Fox jumps over the lazy Dog";
            string str2 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            // Matching the String 
            if(str1 == str2)
            {
                Console.WriteLine("Matched String");

            }
            else
                Console.WriteLine("Not matched String");
           
                
            Console.ReadKey();
        }
        
    }
}
