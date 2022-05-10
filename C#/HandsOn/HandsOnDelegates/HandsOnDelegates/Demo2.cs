using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void MyCalculateDelegate(int a, int b);
    class Calculate
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition : " + (a + b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication : " + (a * b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction : " + (a - b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Division : " + (a / b));
        }
    }
    class Demo2
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            // INSTANTIATE DELEGATE
            MyCalculateDelegate delObj = new MyCalculateDelegate(cal.Add);
            delObj += cal.Div;
            delObj += cal.Sub;
            delObj += cal.Mul;

            delObj(10, 2);
            Console.ReadKey();



        }
    }
}
