using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity
{
    public class Employee
    {

        public int employeeId;
        public string employeeName;
        public string employeeAddress;
        public string employeeCity;

        public string employeeDepartment;
        public int employeeSalary;

        public void SetDetails()
        {
            
            Console.WriteLine("Enter Employee ID ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            employeeName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Address: ");
            employeeAddress = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the City");
            employeeCity = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter The Department");
            employeeDepartment = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            employeeSalary = Convert.ToInt32(Console.ReadLine());

        }

        public void GetDetails()
        {
            Console.WriteLine("Employee Id is : " + employeeId);
            Console.WriteLine("Employee Name is : " + employeeName);
            Console.WriteLine("Employee Name is : " + employeeAddress);
            Console.WriteLine("Employee Work Location is : " + employeeCity);
            Console.WriteLine("Employee Employee Desnigation is : " + employeeDepartment);
            Console.WriteLine("Employee Salary is : " + employeeSalary);
        }
    }
}
