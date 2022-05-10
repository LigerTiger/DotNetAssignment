using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo3
    {
        static void Main(string[] args)
        {
            int[] no= { 23, 34, 54, 67, 78, 76, 54, 43, 32, 21 };
            //DEFERRED EXECUTION
            var op = from i in no
                     where i % 2 == 0
                     select i;
            no[0] = 22; //UPDATE ARRAY (DATASOURCE)
            foreach(var item in op)
            {
                Console.WriteLine(item);
            }
            //IMMEDIATE EXECUTION
            List<int> list = (from i in no
                              where i % 2 == 0
                              select i).ToList();
            no[1] = 35;
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
