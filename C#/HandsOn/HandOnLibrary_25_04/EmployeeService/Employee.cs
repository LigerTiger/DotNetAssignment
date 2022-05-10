using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    public class Employee
    {
        public int empId;
        public string empName;
        //public DateTime joiningDate;
        public int empSalary;
        public string workLocation;
        public string empDesnigation;
        public void Details()
        {
            Console.WriteLine("Employee Id is : " + empId);
            Console.WriteLine("Employee Name is : " + empName);
            //  Console.WriteLine("Employee Joining Date is : " + joiningDate);
            Console.WriteLine("Employee Salary is : " + empSalary);
            Console.WriteLine("Employee Work Location is : " + workLocation);
            Console.WriteLine("Employee Employee Desnigation is : " + empDesnigation);
        }
    }
}
