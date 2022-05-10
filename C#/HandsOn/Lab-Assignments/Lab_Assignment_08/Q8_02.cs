using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_Assignment_08
{
    class Q8_02
    {
   
            static void Main()
            {
                Hashtable hashtable = GetHashtable();
                //Task 1: See if the Hashtable contains the key "Perimeter".
                if (hashtable.ContainsKey("Perimeter"))
                {
                    Console.WriteLine("The Hashtable contains the key \"Perimeter\"");
                }
                else
                {
                    Console.WriteLine("The Hashtable does not contain the key \"Perimeter\"");
                }


                //Task 2: Print the value of "Area" with indexer.
                int index = 0;
                int indexArea = -1;
                foreach (string key in hashtable.Keys)
                {
                    if (hashtable.ContainsKey("Area"))
                    {
                        indexArea = index;
                    }
                    index++;
                }
                if (indexArea != -1)
                {
                    Console.WriteLine("The Hashtable with the key \"Area\" has index {0}", indexArea);
                }
                else
                {
                    Console.WriteLine("The Hashtable does not contain the key \"Area\"");
                }


                Console.WriteLine();
                foreach (string key in hashtable.Keys)
                {
                    Console.WriteLine(string.Format("{0,-20} {1,-20}", key, hashtable[key]));
                }
                //Task 3: Remove the entry for "Mortgage"
                Console.WriteLine();
                if (hashtable.ContainsKey("Mortgage"))
                {
                    hashtable.Remove("Mortgage");
                    Console.WriteLine("The entry for \"Mortgage\" has been deleted.");
                }
                else
                {
                    Console.WriteLine("The Hashtable does not contain the key \"Mortgage\"");
                }
                Console.WriteLine();
                foreach (string key in hashtable.Keys)
                {
                    Console.WriteLine(string.Format("{0,-20} {1,-20}", key, hashtable[key]));
                }


                Console.ReadLine();
            }


        static Hashtable GetHashtable()
        {


            // Create and return new Hashtable.


            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);


            return hashtable;


        }

    }
}
