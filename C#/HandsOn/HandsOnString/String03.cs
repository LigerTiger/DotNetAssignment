using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class String03
    {
        static void Main()
        {
            string[] email = { "Yahoo.com", "gamil.com", "msn.com", "Yahoo.co.in" };
            foreach(string s in email)
            {
                //if(s.EndsWith("com"))
                //{
                //    Console.WriteLine(s);
                //}
                if(s.StartsWith("Y"))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
