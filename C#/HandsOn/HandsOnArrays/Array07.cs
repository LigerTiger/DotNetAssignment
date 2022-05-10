using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Array07
    {
        static void Main()
        {
            string[,] login =
            {
                {"Rohan","12345" },
                {"Ram","12345" },
                {"Abin","12345" },
                {"Manasa","12345" },
                {"Tarun","12345" },
                {"Kiran","12345" },
            };
            Console.Write("Username:");
            string uname = Console.ReadLine();
            Console.Write("Password:");
            string pwd = Console.ReadLine();
            // Console.WriteLine(login.GetUpperBound(0)); //retuns max row index
            bool flag = false;
            for (int i = 0; i <= login.GetUpperBound(0); i++) //i is row index
            {
                if (login[i, 0] == uname && login[i, 1] == pwd)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Invalid User");
            Console.ReadKey();
        }
    }
}
