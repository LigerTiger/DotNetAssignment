using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment_23_04
{
    class ArrayQ_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of an Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter "+n+"Values:");
            for(int i=0;i<ar.Length;i++ )
            {
                ar[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("User Intered Array: ");
            int max = ar[0];
            int min = ar[0];
            Array.Sort(ar);
            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]>max)
                {
                    max = ar[i];
                }
                
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }

            }
            Console.WriteLine("The Maximun array of Integer: " + max);
            Console.WriteLine("The Minimun array of Integer: " + min);
            Console.ReadKey();


            
        }
    }
}
