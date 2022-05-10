using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    // DELEGATES DECLARATION
    public delegate void MyDelegate();
    class Sample
    {
        public void Task()
        {
            Console.WriteLine("Task is Running...");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            //INSTANTIATE DELAGATES
            MyDelegate dejObj = new MyDelegate(s1.Task); // REFER TASK METHOD
            // CALLING DELEGATES
            dejObj(); // INVOKING DELEGATES
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
