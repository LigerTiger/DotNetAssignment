using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_Assignment_08
{
    class Q8_01
    {




        static void Main(string[] args)
        {
            Hashtable districts = new Hashtable();
            int choice = 0;


            while (choice != 6)
            {


                Console.WriteLine("1. Add a new record in hashtable");
                Console.WriteLine("2. Search a record");
                Console.WriteLine("3. Display all records");
                Console.WriteLine("4. Display total count of records");
                Console.WriteLine("5. Remove particular record");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice: ");


                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {


                            Console.Write("Enter the district number (Example MH01): ");
                            string districtNumber = Console.ReadLine();
                            Console.Write("Enter the district name: ");
                            string districtName = Console.ReadLine();
                            districts.Add(districtNumber, districtName);
                            Console.WriteLine("\nThe district has been added!\n");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter the district number to search: ");
                            string districtNumber = Console.ReadLine();
                            bool exist = false;
                            foreach (string key in districts.Keys)
                            {
                                if (key == districtNumber)
                                {
                                    Console.WriteLine(string.Format("{0,-20}{1,-20}", "District Number", "Name"));
                                    Console.WriteLine(string.Format("{0,-20}{1,-20}", key, districts[key]));
                                    exist = true;
                                    break;
                                }
                            }


                            if (!exist)
                            {
                                Console.WriteLine("\nThe district does not exist!\n");
                            }
                        }


                        break;
                    case 3:
                        {
                            Console.WriteLine("All districts");
                            Console.WriteLine(string.Format("{0,-20}{1,-20}", "District Number", "Name"));
                            foreach (DictionaryEntry d in districts)
                            {
                                Console.WriteLine(string.Format("{0,-20}{1,-20}", d.Key, d.Value));
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("The total number of records is {0}", districts.Count);
                        break;
                    case 5:
                        {
                            Console.Write("Enter the district number to delete: ");
                            string districtNumber = Console.ReadLine();
                            if (districts.ContainsKey(districtNumber) || districts.ContainsValue(districtNumber))
                            {
                                districts.Remove(districtNumber);
                                Console.WriteLine("\nThe district has been deleted!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nThe district does not exist!\n");
                            }
                        }
                        break;
                    case 6:
                        return;
                        
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }


            Console.ReadKey();


        }
    }
}
