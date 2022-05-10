using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService;
namespace Employee_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.empId = 123;
            e.empName = "Ankit";
            //e.joiningDate=DateTime.Parse("14/04/22");
            e.empSalary = 28856;
            e.workLocation = "Pune";
            e.empDesnigation = "Full Stack Developer";
            e.Details();
            Employee e1 = new Employee();
            Console.Write("Enter EmployeeId : ");
            e1.empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            e1.empName = Convert.ToString(Console.ReadLine());
            /*Console.WriteLine("Enter Joining date : ");
            e1.joiningDate = DateTime.Parse(Console.Read());*/
            Console.Write("Enter Salary : ");
            e1.empSalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Work Location : ");
            e1.workLocation = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Desgination : ");
            e1.empDesnigation = Convert.ToString(Console.ReadLine());
            e1.Details();
            Console.ReadKey();
        }
    }
}
