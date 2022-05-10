using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_06
{
    
        
        //TASK 1: DEFINE A CUSTOMER CLASS WITH FOLLOWING MEMBERS CUSTOMERID, CUSTOMER NAME, ADDRESS, CITY, PHONE, CREDITLIMIT
        class Customer
        {
            private int id;


            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            private string name;
            //TASK 2: DEFINE THE PROPERTIES FOR ALL THESE MEMBERS.
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private string address;


            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            private string city;


            public string City
            {
                get { return city; }
                set { city = value; }
            }
            private string phone;


            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
            private decimal creditLimit;


            public decimal CreditLimit
            {
                get { return creditLimit; }
                set
                {
                    //TASK 4: YOU NEED TO VALIDATE THE CREDITLIMIT. 
                    //IF THE VALUE IS ABOVE 50000, THEN YOU NEED TO RAISE EXCEPTION TO HANDLE THIS.

                    if (value > 50000)
                    {
                        //TASK 5: USE THE EXCEPTION CLASS CREATED TO THROW THE EXCEPTION
                        throw new InvalidCreditLimit("The value is above 50000.");
                    }
                    creditLimit = value;
                }
            }


            //TASK 3: DEFINE TWO CONSTRUCTORS (DEFAULT AND PARAMETERISED) TO ASSIGN THE VALUES.
            public Customer() { }


            public Customer(int id, string name, string address, string city, string phone, decimal creditLimit)
            {
                this.id = id;
                this.name = name;
                this.address = address;
                this.city = city;
                this.phone = phone;
                this.CreditLimit = creditLimit;
            }

        }
    //CREATE INVALIDCREDITLIMIT CUSTOM EXCEPTION CLASS TO ACHIEVE THE SAME.
    class InvalidCreditLimit : Exception
    {
        public InvalidCreditLimit(string message) : base(message)
        {

        }
    }
    class CostomerTest
    {

        static void Main(string[] args)
        {
            //THE CLIENT APPLICATION CATCHES THE EXCEPTION AND HANDLES THE ERROR PROPERLY.
            try
            {

                Customer customer1 = new Customer(101441, "Amit Kumar", "Main Road 24", "Bangalore", "045523658", 2522);
                //DISPLAY CUSTOMERID, CUSTOMER NAME, ADDRESS, CITY, PHONE, CREDITLIMIT
                Console.WriteLine("Customer Id: {0}", customer1.Id);
                Console.WriteLine("Customer Name: {0}", customer1.Name);
                Console.WriteLine("Customer Address: {0}", customer1.Address);
                Console.WriteLine("Customer City: {0}", customer1.City);
                Console.WriteLine("Customer Phone: {0}", customer1.Phone);
                Console.WriteLine("Customer CreditLimit: {0}", customer1.CreditLimit);
                Customer customer2 = new Customer(2, "Ankit Kumar Chaudhary", "Main Road 24", "Bangalore", "056999874", 251245);
            }
            catch (InvalidCreditLimit ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
