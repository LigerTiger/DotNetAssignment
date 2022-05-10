using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo1
    {
        static void Main(string[] args)
        {
            string[] name = { "Amit", "Ankit", "Swati", "Ishwarya" };
            //RETURN NAME START WITH A
            var op = from s in name
                     where s.StartsWith('A')
                     select s;
            // RETUN NAME WHO'S LENGHT 
            foreach(var item in op)
            {
                Console.WriteLine(item);
            }
            var op1 = from s in name
                     where s.EndsWith('a')
                     select s;
            foreach (var item in op1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
