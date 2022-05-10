using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_07
{
    class ContactList_01
    {
        private static List<Contact_01> contacts = new List<Contact_01>();

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Options:
                    1. Add contact
                    2. Display contact
                    3. Edit contact
                    4. Show all contacts
                    5. Quit");
                Console.Write("Choose an option (1-5): ");
                var input = Console.ReadLine();


                if (!int.TryParse(input, out var option))
                {
                    Console.WriteLine();
                    continue;
                }


                switch (option)
                {
                    case 1:
                        AddContact();
                        break;


                    case 2:
                        DisplayContact();
                        break;


                    case 3:
                        EditContact();
                        break;


                    case 4:
                        ShowAllContacts();
                        break;


                    case 5:
                        return;


                    default:
                        break;
                }


                Console.WriteLine();
            }
        }


        private static void AddContact()
        {
            var contact = new Contact_01();

            Console.Write("Input contact no: ");
            contact.ContactNo = long.Parse(Console.ReadLine());


            Console.Write("Input contact name: ");
            contact.ContactName = Console.ReadLine();


            Console.Write("Input cell no: ");
            contact.CellNo = Console.ReadLine();


            contacts.Add(contact);
            Console.WriteLine("Contact has been added");
        }


        private static void DisplayContact()
        {
            Console.Write("Input contact no: ");
            var contactNo = long.Parse(Console.ReadLine());


            foreach (var item in contacts)
            {
                if (item.ContactNo == contactNo)
                {
                    Console.WriteLine(item);
                    return;
                }
            }


            Console.WriteLine("Error: contact with entered number does not exist!");
        }


        private static void EditContact()
        {
            Console.Write("Input contact no: ");
            var contactNo = int.Parse(Console.ReadLine());


            Contact_01 contact = null;
            foreach (var item in contacts)
            {
                if (item.ContactNo == contactNo)
                {
                    contact = item;
                    break;
                }
            }


            if (contact == null)
            {
                Console.WriteLine("Error: contact with entered number does not exist!");
                return;
            }


            Console.Write("Input new contact no: ");
            contact.ContactNo = int.Parse(Console.ReadLine());


            Console.Write("Input new contact name: ");
            contact.ContactName = Console.ReadLine();


            Console.Write("Input new cell no: ");
            contact.CellNo = Console.ReadLine();

            Console.WriteLine("Contact has been updated");
            Console.WriteLine();
        }


        private static void ShowAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts");
                return;
            }

            for (var i = 0; i < contacts.Count; i++)
                Console.WriteLine($"{i + 1}. {contacts[i]}");
        }
    }


    
}

