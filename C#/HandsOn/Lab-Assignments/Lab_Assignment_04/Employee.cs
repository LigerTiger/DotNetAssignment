using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_04
{
    class Program
    {


        abstract class Employee
        {
            public double Salary { get; set; }
            public Employee() { }
            public Employee(double s)
            {
                this.Salary = s;
            }
            public abstract double GetSalary();
        }


        class ContractEmployee : Employee
        {
            public double Perks { get; set; }
            public ContractEmployee() { }
            public ContractEmployee(double p, double s)
                : base(s)
            {
                this.Perks = p;
            }
            public override double GetSalary()
            {
                return Salary + Perks;
            }
        }
        class PermanentEmployee : Employee
        {
            public int NoOfLeaves { get; set; }
            public double ProvidendFund { get; set; }
            public PermanentEmployee() { }
            public PermanentEmployee(int noOfLeaves, double providendFund, double salary)
                : base(salary)
            {
                this.NoOfLeaves = noOfLeaves;
                this.ProvidendFund = providendFund;
            }
            public override double GetSalary()
            {
                return Salary - ProvidendFund;
            }
        }






        static void Main(string[] args)
        {


            Employee newEmp = null;
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("1. Add contract employee");
                Console.WriteLine("2. Add permanent employee");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            newEmp = new ContractEmployee();
                            Console.Write("Enter the salary: ");
                            newEmp.Salary = double.Parse(Console.ReadLine());
                            Console.Write("Enter the perks: ");
                            ((ContractEmployee)newEmp).Perks = double.Parse(Console.ReadLine());
                            Console.WriteLine("Contract employee");
                            Console.WriteLine("Salary: {0}", newEmp.Salary.ToString("C"));
                            Console.WriteLine("Perks: {0}", ((ContractEmployee)newEmp).Perks.ToString("C"));
                            Console.WriteLine("Salary: {0}", newEmp.GetSalary().ToString("C"));
                        }
                        break;
                    case 2:
                        {
                            newEmp = new PermanentEmployee();
                            Console.Write("Enter salary: ");
                            newEmp.Salary = double.Parse(Console.ReadLine());
                            Console.Write("Enter the number of leaves: ");
                            ((PermanentEmployee)newEmp).NoOfLeaves = int.Parse(Console.ReadLine());
                            Console.Write("Enter the providend fund: ");
                            ((PermanentEmployee)newEmp).ProvidendFund = double.Parse(Console.ReadLine());
                            Console.WriteLine("Permanent employee");
                            Console.WriteLine("Salary: {0}", newEmp.Salary.ToString("C"));
                            Console.WriteLine("No of leaves: {0}", ((PermanentEmployee)newEmp).NoOfLeaves);
                            Console.WriteLine("Providend fund: {0}", ((PermanentEmployee)newEmp).ProvidendFund.ToString("C"));
                            Console.WriteLine("Salary: {0}", newEmp.GetSalary().ToString("C"));
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }


        }
    }
}
