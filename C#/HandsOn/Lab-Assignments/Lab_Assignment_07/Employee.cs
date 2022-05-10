using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_07
{
    
        class Employee
        {
            //EMPLOYEE CLASS WILL HAVE EMPLOYEE NUMBER, NAME AND BASIC SALARY, AND PF ATTRIBUTES
            private int employeeNumber;


            public int EmployeeNumber
            {
                get { return employeeNumber; }
                set { employeeNumber = value; }
            }
            private string name;


            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private double basicSalary;


            public double BasicSalary
            {
                get { return basicSalary; }
                set { basicSalary = value; }
            }
            private double pf;


            public double PF
            {
                get { return pf; }
                set { pf = value; }
            }




            public Employee() { }


            public Employee(int employeeNumber, string name, double basicSalary, double pf)
            {
                this.employeeNumber = employeeNumber;
                this.name = name;
                this.basicSalary = basicSalary;
                this.pf = pf;
            }




            public override string ToString()
            {
                return string.Format("{0,-20}{1,-20}{2,-20}{3,-20}", EmployeeNumber, Name, BasicSalary.ToString("C"), PF);
            }
        

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Display all employees");
                Console.WriteLine("3. Delete currently searched employee");
                Console.WriteLine("4. Search a employee");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Employee newEmployee = new Employee();
                            Console.Write("Enter the Employee Number: ");
                            newEmployee.EmployeeNumber = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Employee Name: ");
                            newEmployee.Name = Console.ReadLine();
                            Console.Write("Enter the Employee Basic Salary: ");
                            newEmployee.BasicSalary = double.Parse(Console.ReadLine());
                            Console.Write("Enter the Employee PF: ");
                            newEmployee.PF = int.Parse(Console.ReadLine());
                            employees.Add(newEmployee);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("All employees");
                            Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}{3,-20}", "Employee Number", "Name", "Basic Salary", "PF"));
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter the Employee Number to delete: ");
                            int employeeNumber = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Employee e in employees)
                            {
                                if (e.EmployeeNumber == employeeNumber)
                                {
                                    employees.Remove(e);
                                    exist = true;
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe Employee Number does not exist!\n");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Enter the Employee Number No to search: ");
                            int employeeNumber = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Employee e in employees)
                            {
                                if (e.EmployeeNumber == employeeNumber)
                                {
                                    Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}{3,-20}", "Employee Number", "Name", "Basic Salary", "PF"));
                                    Console.WriteLine(e.ToString());
                                    exist = true;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe Employee does not exist!\n");
                            }
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }

            Console.ReadKey();


        }
    }
}
