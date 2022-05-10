using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_14
{
    class Guest
    {
        //GUESTID SHOULD BE 3 DIGITS LONG
        private int guestID;


        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        //GUEST NAME CAN ACCEPT ALPHABETS ONLY. IT SHOULD START WITH CAPITAL ALPHABET AND SHOULD HAVE MINIMUM 3 CHARACTERS
        private string guestName;


        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }
        //CONTACT NUMBER SHOULD HAVE 10 DIGITS EXCTLY. IT SHOULD START WITH 6 OR 7 OR 8 OR 9.
        private long contactNumber;


        public long ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
       
        public Guest() { }


       
        public Guest(int guestID, string guestName, long contactNumber)
        {
            this.guestID = guestID;
            this.guestName = guestName;
            this.contactNumber = contactNumber;
        }
        
        // DISPLAY INFO
        
        public void display()
        {
            Console.WriteLine("Gest ID: {0}", this.guestID);
            Console.WriteLine("Gest name: {0}", this.guestName);
            Console.WriteLine("Gest contact number: {0}\n", this.contactNumber);
        }
    }


    class GuestDB
    {
        private List<Guest> guests;
        public GuestDB()
        {
            this.guests = new List<Guest>();
        }
        
        //ADDS A NEW GUEST
      
       
        public void AddGuest(Guest guest)
        {
            this.guests.Add(guest);
        }
        
        // DISPLAY ALL GUESTS
        
        public void displayAllGuests()
        {
            for (int i = 0; i < this.guests.Count; i++)
            {
                this.guests[i].display();
            }
        }


    }


    class UI
    {


        private GuestDB guestDB;
        public UI()
        {
            this.guestDB = new GuestDB();
        }


        public void run()
        {
            for (int g = 0; g < 5; g++)
            {
                Guest guest = new Guest();
                int ID = 0;
                long contactNumber = 0;
                string inputValue = "";
                while (inputValue == "")
                {
                    Console.Write("Enter a guest ID: ");
                    inputValue = Console.ReadLine();
                    if (inputValue.Length != 3)
                    {
                        inputValue = "";
                        Console.WriteLine("\nGuest ID should be 3 digits long.\n");


                    }
                    else
                    {


                        if (!int.TryParse(inputValue, out ID))
                        {
                            Console.WriteLine("\nGuest ID should be 3 digits long.\n");
                        }
                    }
                }
                guest.GuestID = ID;
                // CAN ACCEPT ALPHABETS ONLY. IT SHOULD START WITH CAPITAL ALPHABET AND SHOULD HAVE MINIMUM 3 CHARACTERS
                inputValue = "";
                while (inputValue == "")
                {
                    Console.Write("Enter a guest name: ");
                    inputValue = Console.ReadLine();
                    if (inputValue.Length < 3)
                    {
                        inputValue = "";
                        Console.WriteLine("\nGuest name should have minimum 3 characters.\n");


                    }
                    else
                    {
                        if (!char.IsUpper(inputValue[0]))
                        {
                            inputValue = "";
                            Console.WriteLine("\nGuest name should start with Capital Alphabet.\n");
                        }
                        else
                        {
                            bool isLetter = true;
                            for (int i = 0; i < inputValue.Length; i++)
                            {
                                if (!char.IsLetter(inputValue[i]))
                                {
                                    isLetter = false;
                                    break;
                                }
                            }
                            if (!isLetter)
                            {
                                inputValue = "";
                                Console.WriteLine("\nGuest name should be a alphabet value.\n");
                            }
                        }
                    }
                   
                }
                guest.GuestName = inputValue;
                //SHOULD HAVE 10 DIGITS EXCTLY. IT SHOULD START WITH 6 OR 7 OR 8 OR 9.
                inputValue = "";
                while (inputValue == "")
                {
                    Console.Write("Enter a guest contact number: ");
                    inputValue = Console.ReadLine();
                    if (inputValue.Length != 10)
                    {
                        inputValue = "";
                        Console.WriteLine("\nGuest contact number should have 10 digits exctly.\n");


                    }
                    else
                    {
                        if (inputValue[0] != '6' && inputValue[0] != '7' && inputValue[0] != '8' && inputValue[0] != '9')
                        {
                            inputValue = "";
                            Console.WriteLine("\nGuest contact number should start with 6 or 7 or 8 or 9.\n");
                        }
                        else
                        {
                            if (!long.TryParse(inputValue, out contactNumber))
                            {
                                inputValue = "";
                                Console.WriteLine("\nGuest ID should be digits only.\n");
                            }
                        }
                    }
                }
                guest.ContactNumber = contactNumber;
                guestDB.AddGuest(guest);
               
            }
            guestDB.displayAllGuests();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            UI UI = new UI();
            UI.run();
           


            Guest guest = new Guest();
            guest.display();
            Console.ReadKey();
        }

        
    }
}
