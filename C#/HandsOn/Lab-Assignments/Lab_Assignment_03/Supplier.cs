using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_03
{
    class Supplier
    {
        
            int Supplierid;
            string SupplierName;
            string City;
            string PhoneNum;
            string Email;

            public void AcceptDetails()
            {
                Console.WriteLine("Enter Supplier's ID:");
                this.Supplierid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Supplier's name:");
                this.SupplierName = Console.ReadLine();

                Console.WriteLine("Enter Supplier's city:");
                this.City = Console.ReadLine();

                Console.WriteLine("Enter Supplier's phone number:");
                this.PhoneNum = Console.ReadLine();

                Console.WriteLine("Enter Supplier's email:");
                this.Email = Console.ReadLine();
            }

            public void DisplayDetails()
            {
                Console.WriteLine("\nInformation about Supplier");
                Console.WriteLine("ID: " + this.Supplierid);
                Console.WriteLine("Name: " + this.SupplierName);
                Console.WriteLine("City: " + this.City);
                Console.WriteLine("Phone number: " + this.PhoneNum);
                Console.WriteLine("Email: " + this.Email);

            }
    }
}
