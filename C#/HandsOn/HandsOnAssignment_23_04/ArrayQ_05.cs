using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment_23_04
{
    class ArrayQ_05
    {
        static void Main(string[] args)
        {
            int n, m, p;
            Console.WriteLine("Enter number of arrays");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n + 1];
            Console.WriteLine("Ener the array values: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the index of new value to be Insert");
            m= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new value to be Insert");
            p= Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n + 1; i++)
            {
                if (i<m)
                {
                    b[i] = a[i];
                }
                else if(i==m)
                {
                    b[i] = p;
                }
                else
                {
                    b[i] = a[i - 1];
                }
            }
            Console.WriteLine("Elements are: ");
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();
        }

    }
}
