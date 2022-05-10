using System;

namespace Lab_Assignment_03
{
    class Car
    {
        private string make;


        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private string model;


        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int year;


        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double salePrice;


        public double SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

        public Car() { }

        public Car(string make, string model, int year, double salePrice)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.salePrice = salePrice;
        }
        static void Main(string[] args)
        {
            string choice = " ";
            Car[] cars = new Car[100];
            int totalCarsInCatalog = 0;
            string make;
            string model;
            int year;
            double salePrice;
            int ID;
            while (choice.CompareTo("6") != 0)
            {
                Console.WriteLine("1. Adding a new car");
                Console.WriteLine("2. Modify the details of a particular car");
                Console.WriteLine("3. Search for a particular car in the Catalog");
                Console.WriteLine("4. List all the cars in the Catalog");
                Console.WriteLine("5. Delete a car from the Catalog");
                Console.WriteLine("6. Quit");


                Console.Write("Select one menu item: ");
                choice = Console.ReadLine();
                if (choice.CompareTo("1") == 0)
                {
                    // ADD NEW CAR 
                    Console.Write("Enter make of a car: ");
                    make = Console.ReadLine();
                    Console.Write("Enter model of a car: ");
                    model = Console.ReadLine();
                    Console.Write("Enter year of a car: ");
                    year = int.Parse(Console.ReadLine());
                    Console.Write("Enter sale price of a car: ");
                    salePrice = double.Parse(Console.ReadLine());
                    cars[totalCarsInCatalog] = new Car(make, model, year, salePrice);
                    totalCarsInCatalog++;
                }
                else if (choice.CompareTo("2") == 0)
                {
                    // MODIFY THE CAR CATALOG
                    if (totalCarsInCatalog > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCarsInCatalog; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                        }
                        Console.Write("Enter ID of a car you want to edit: ");
                        ID = int.Parse(Console.ReadLine());
                        ID--;
                        if (ID >= 0 && ID < totalCarsInCatalog)
                        {
                            Console.Write("Enter a new make of a car: ");
                            make = Console.ReadLine();
                            Console.Write("Enter a new model of a car: ");
                            model = Console.ReadLine();
                            Console.Write("Enter a new year of a car: ");
                            year = int.Parse(Console.ReadLine());
                            Console.Write("Enter a new sale price of a car: ");
                            salePrice = double.Parse(Console.ReadLine());
                            cars[ID] = new Car(make, model, year, salePrice);
                            Console.WriteLine("\nSelected car has been updated.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nSelect correct ID.\n");
                        }
                    }
                }
                else if (choice.CompareTo("3") == 0)
                {
                    // SEAECH ALL CAR PARTICULAR
                    if (totalCarsInCatalog > 0)
                    {
                        Console.Write("Enter make or model of a car you want to search: ");
                        make = Console.ReadLine();
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCarsInCatalog; i++)
                        {
                            bool isFound = false;
                            if (cars[i].Make.CompareTo(make) == 0 || cars[i].Model.CompareTo(make) == 0)
                            {
                                Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                                isFound = true;
                            }
                            if (!isFound)
                            {
                                Console.WriteLine("\nThe car with such make or model does not exist.\n");
                            }
                        }
                    }
                }
                else if (choice.CompareTo("4") == 0)
                {
                    // LIST ALL CAR CATALOG
                    if (totalCarsInCatalog > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCarsInCatalog; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                        }
                    }
                }
                else if (choice.CompareTo("5") == 0)
                {
                    // DELETE A CAR FROM THE CATALOG

                    if (totalCarsInCatalog > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCarsInCatalog; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                        }
                        Console.Write("Enter ID of a car you want to delete: ");
                        ID = int.Parse(Console.ReadLine());
                        ID--;
                        if (ID >= 0 && ID < totalCarsInCatalog)
                        {
                            for (int i = ID; i < totalCarsInCatalog - 1; i++)
                            {
                                cars[i] = cars[i + 1];
                            }
                            totalCarsInCatalog--;
                            Console.WriteLine("\nSelected car has been deleted.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nSelect correct ID.\n");
                        }
                    }
                }
                else if (choice.CompareTo("6") == 0)
                {

                }
                else
                {
                    Console.WriteLine("Select correct menu item.");
                }
            }

        }

    }
}
