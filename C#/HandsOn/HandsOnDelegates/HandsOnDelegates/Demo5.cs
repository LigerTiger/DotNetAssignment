using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate string Delegate1();
    class Demo5
    {
        public string Greet()
        {
            return "Hello User ";
        }
        public void M(Delegate1 d)
        {
            // INVOKING DELEGATE
            Console.Write(d());
        }
        static void Main()
        {
            Demo5 ob = new Demo5();
            ob.M(ob.Greet);
            ob.M(() => "Good Morning ");
            Console.ReadKey();
        }
    }
}
