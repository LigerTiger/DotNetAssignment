using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment_23_04
{
    class ArrayQ_04
    {

        static int[] removeArray(int[] x, int ind)
        {
            if (ind < 0 || ind > x.Length)
            {
                Console.WriteLine("Out-Of-Bounds");
                return x;
            }
            int[] y = new int[x.Length-1];  // -1
            for(int i=0; i < y.Length; i++)
            {
                if (i < ind)
                    y[i] = x[i];
                else
                    y[i] = x[i+1]; 
            }       
            return y ;
        }
          
        static void Main(string[] args)
        {
            int[] a = new int[0];                               //{9,2,4,3,1,5};
            int b = Convert.ToInt32(Console.ReadLine());
            a = removeArray(a, b);


           /* Console.WriteLine("Element are: ");
            for (int i = 0; i <a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }*/
            

            Console.ReadKey();
        }
    }
}
