using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    class Demo4
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Square(double a)
        {
            return a * a;
        }
        public bool IsEven(int n)
        {
            return n / 2 == 0 ? true : false;
        }
        public void Greet(string s)
        {
            Console.WriteLine("Hello "+s);
        }
        static void Main(string[] args)
        {
            Demo4 obj = new Demo4();
            // Func delegate are refer methods with return
            Func<int, int, int> func = obj.Add;
            int result = func(10, 15);
            Console.WriteLine(result);
            Func<double,double> func1 = obj.Square;
            Console.WriteLine(func1(12));
            Func<int, bool> func2 = obj.IsEven;
            if (func2(12))
            {
                Console.WriteLine("Even Value");
            }
            else
            {
                Console.WriteLine("Odd Value");
            }
            // Action delegates invoke funtions with no return value
            Action<string> action = obj.Greet;
            action("Ankit");
            // Predicate delegate invoke methods which return boolean value
            Predicate<int> predicate = obj.IsEven;
            if (predicate(12))
            {
                Console.WriteLine("Even Value");

            }
            else
            {
                Console.WriteLine("Odd Values");
            }
            Console.ReadKey();
            
        }
    }
}
