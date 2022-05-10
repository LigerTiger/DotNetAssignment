using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo4
    {
        static void Main(string[] args)
        {   // LET KEYWORD IS USED TO USE TEMP VARIABLSs IN THE QUERY
            int[] no = { 23, 34, 54, 67, 78, 76, 54, 43, 32, 21 };
            // RETURN SQUARE OF ARRAY NOS
            var op = (from i in no
                      let k = i * i
                      select k).ToArray();
            // RETURN SQUARE OF ARRAY NO'S > 1000
            op = (from i in no
                  let k = i * i
                  where k > 1000
                  select k).ToArray();
            foreach(var item in op)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
