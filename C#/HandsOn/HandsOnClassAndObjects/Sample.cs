using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Sample
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello "+name);
        }
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addtion of{0},{1} is {2}", a,b,result);

        }

        public double Square(double n)
        {
            double result= n * n;
            return result;


        }
        public string Message(string name)
        {
            return "Good Morning " + name;
        }
        public bool IsEven(int no)
        {
            if (no % 2 == 0)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.Greet("Amith");
            sample.Greet("Renuka");
            sample.Add(12, 23);
            sample.Add(34, 45);

            double result = sample.Square(12);
            Console.WriteLine(result);
            string message = sample.Message("Sachin");
            Console.WriteLine(message);
            Console.WriteLine("Enter a no");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine(sample.IsEven(no)?"Even":"Odd");
            Console.ReadKey();

        }
    }
}
