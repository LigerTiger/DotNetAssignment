using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignment2
{
    class StringQ_D
    {
        static void Main(string[] args)
        {
            
            string stmt = "The quick brown fox jumps over the lazy dog";
            int count = 0;
            string word1 = null;
            string word2 = null;
            for (int lastindex = stmt.Length - 1; lastindex > 0; lastindex--)
            {
                if (count < 3)
                {
                    word1 = word1 + stmt[lastindex];
                    count++;
                }
                else
                {
                    break;
                }
            }
            for (int i = word1.Length - 1; i >= 0; i--)
            {
                word2 = word2 + word1[i];
            }
            if (word2 == "dogs")
            {
                Console.WriteLine("Word is present at the end of statements");
            }
            else
            {
                Console.WriteLine("Word is not present at the end of statements");
            }
            Console.ReadKey();
        }
    }
}
