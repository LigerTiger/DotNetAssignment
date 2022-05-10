using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void GreetDelegates(string n);
    class Demo1
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello "+name);
        }
        static void Main(string[] args)
        {
            Demo1 d = new Demo1();
            GreetDelegates d1 = new GreetDelegates(d.Greet);
            d1("Ankit");
            Console.ReadKey();
        }
    }
}
