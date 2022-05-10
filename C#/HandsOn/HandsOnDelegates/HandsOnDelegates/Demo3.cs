using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate double CubeDelegate(double i);
    class Demo3
    {
        public static double Cube(double n)
        {
            return Math.Pow(n, 3);
        }
        static void Main(string[] args)
        {
            CubeDelegate delObj = new CubeDelegate(Cube);
            double result = delObj(5);
            Console.WriteLine("Result: "+result);
            CubeDelegate delObj1 = (i) => i *i *i;
            double result1= delObj(10);
            Console.WriteLine("Result: " + result1);
            Console.ReadKey();


        }
    }
}
