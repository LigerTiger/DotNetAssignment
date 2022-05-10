using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_09
{
    class Program


    {
        static bool keyIsAlreadyDictionary(Dictionary<string, string> countries, string country)
        {
            if (countries.ContainsKey(country))
            {
                throw new ArgumentException("This key \"" + country + "\" is already in dictionary");
            }
            return false;
        }


        static void Main()
        {
            //CREATE A NEW DICTIONARY OF STRINGS, WITH STRING KEYS.
            Dictionary<string, string> countries = new Dictionary<string, string>();
            
            countries.Add("Italy", "Rome");
            countries.Add("India", "New Delhi");
            countries.Add("China", "Peking ");
            countries.Add("Chile", "Santiago");
            countries.Add("USA", "Washington");
            countries.Add("Ukraine", "Kiev");
            countries.Add("Turkey", "Ankara");
            countries.Add("Zimbabwe", "Harare");
            countries.Add("Thailand", "Bangkok");
            countries.Add("South Korea", "Seoul");
            countries.Add("Serbia", "Belgrade");
            countries.Add("Pakistan", "Islamabad");
            try
            {
                if (!keyIsAlreadyDictionary(countries, "Pakistan"))
                {
                    countries.Add("Pakistan", "Islamabad");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
            if (countries.ContainsKey("Serbia"))
            {
                countries["Serbia"] = "New Serbia";
                Console.WriteLine("The capital of country \"Serbia\" has been changed. A new capital is \"" + countries["Serbia"] + "\"\n");


            }
           
            try
            {
                if (!keyIsAlreadyDictionary(countries, "Poland"))
                {
                    countries.Add("Poland", "Warsaw");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.WriteLine();
            foreach (string key in countries.Keys)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-20}", key, countries[key]));
            }
           
            Console.WriteLine();
            if (countries.ContainsKey("Chile"))
            {
                countries.Remove("Chile");
                Console.WriteLine("The entry for \"Chile\" has been deleted.");
            }
            else
            {
                Console.WriteLine("The dictionary does not contain the key \"Chile\"");
            }
            Console.WriteLine();
            foreach (string key in countries.Keys)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-20}", key, countries[key]));
            }


            
            try
            {
                Console.WriteLine(countries["Serbia 1"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
