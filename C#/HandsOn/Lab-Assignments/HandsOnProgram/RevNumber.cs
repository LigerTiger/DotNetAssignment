using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgram
{
    class RevNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the iputs: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(n>0)
            {
                int mod=n%10;
                rev = ((rev * 10 )+ mod);
                n = (n / 10);
            }
            Console.WriteLine($"Reverse the numbers are : {rev} ");
            
            Console.ReadLine();
        }
    }
}
