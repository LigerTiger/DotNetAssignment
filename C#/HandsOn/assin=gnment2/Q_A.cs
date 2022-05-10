using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class Q_A
    {
		static void Main(string[] args)
		{
         
            String s = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine( "Enter Number of index ");
            int n = Convert.ToInt32(Console.ReadLine());
            char c = s[n];
            Console.WriteLine("The character on 12th index is :" + c);
            Console.ReadKey();
            Console.ReadKey();	
		}
    }
}
