using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeEntity;

namespace Employee_Client
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee e1 = new Employee();
            e1.employeeId = 1001;
            e1.employeeName = "Ankit Kumar ChaudharyS";
            e1.employeeAddress = "103 Chinar Royal ";
            e1.employeeCity = "Pune";
            e1.employeeDepartment = "Software Engineering";
            e1.employeeSalary = 21009;
            e1.GetDetails();

            Employee[] e = new Employee[10];
            
            for(int i=0;i<10;i++)
            {
                e[i] = new Employee();
            }
            for(int i=0;i<10;i++)
            {
                e[i].SetDetails();
            }
            for(int i=0;i<10;i++)
            {
                e[i].GetDetails();
            }
            
                Console.ReadKey();
        }
    }
}
