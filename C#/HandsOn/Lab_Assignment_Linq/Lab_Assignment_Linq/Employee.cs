using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_Linq
{

    class Employee
    {
        class Employee1
        { 
        public int EmployeeID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Title { set; get; }
        public DateTime DOB { set; get; }
        public DateTime DOJ { set; get; }
        public string City { set; get; }
        }
        static void Main()
        {
            List<Employee1> employees = new List<Employee1>()
            {
                new Employee1(){ EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager" ,     DOB=Convert.ToDateTime("16/11/1984") , DOJ=Convert.ToDateTime("08/06/2011") ,City = "Mumbai" },
                new Employee1(){ EmployeeID=1002, FirstName="Asdin",   LastName="Dhalla",    Title="AsstManager" , DOB=Convert.ToDateTime("20/08/1984") , DOJ=Convert.ToDateTime("07/07/2012") ,City = "Mumbai"},
                new Employee1(){ EmployeeID=1003, FirstName="Madhavi", LastName="Oza",       Title="Consultant" ,  DOB=Convert.ToDateTime("14/11/1987") , DOJ=Convert.ToDateTime("12/04/2015") ,City = "Pune"},
                new Employee1(){ EmployeeID=1004, FirstName="Saba",    LastName="Shaikh",    Title="SE" ,          DOB=Convert.ToDateTime("03/06/1990") , DOJ=Convert.ToDateTime("02/02/2016") ,City = "Pune"},
                new Employee1(){ EmployeeID=1005, FirstName="Nazia",   LastName="Shaikh",    Title="SE" ,          DOB=Convert.ToDateTime("08/03/1991") , DOJ=Convert.ToDateTime("02/02/2016") ,City = "Mumbai"},
                new Employee1(){ EmployeeID=1006, FirstName="Amit",    LastName="Pathak",    Title="Consultant" ,  DOB=Convert.ToDateTime("07/11/1989") , DOJ=Convert.ToDateTime("08/08/2014") ,City = "Chennai"},
                new Employee1(){ EmployeeID=1007, FirstName="Vijay",   LastName="Natrajan",  Title="Consultant" ,  DOB=Convert.ToDateTime("02/12/1989") , DOJ=Convert.ToDateTime("01/06/2015") ,City = "Mumbai"},
                new Employee1(){ EmployeeID=1008, FirstName="Rahul",   LastName="Dubey",     Title="Associate" ,   DOB=Convert.ToDateTime("11/11/1993") , DOJ=Convert.ToDateTime("06/11/2014") ,City = "Chennai"},
                new Employee1(){ EmployeeID=1009, FirstName="Suresh",  LastName="Mistry",    Title="Associate"  ,  DOB=Convert.ToDateTime("12/08/1992") , DOJ=Convert.ToDateTime("03/12/2014") ,City = "Chennai"},
                new Employee1(){ EmployeeID=1010, FirstName="Sumit",   LastName="Shah",      Title="Manager" ,     DOB=Convert.ToDateTime("12/04/1991") , DOJ=Convert.ToDateTime("02/01/2016") ,City = "Pune"},
            };

            // Task a
            Console.WriteLine("Task A : Display detail of all the employee ");
            Console.WriteLine();
            var result = from s in employees
                         select s;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();

            
            Console.WriteLine("Task B : Display details of all the employee whose location is not Mumbai");
            Console.WriteLine();
            result = from s in employees
                     where s.City != "Mumbai"
                     select s;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task C : Display details of all the employee whose title is AsstManager");
            Console.WriteLine();
            result = from s in employees
                     where s.Title == "AsstManager"
                     select s;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task D :  Display details of all the employee whose Last Name start with S");
            Console.WriteLine();
            result = from s in employees
                     where s.LastName.StartsWith("S")
                     select s;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task E : Display a list of all the employee who have joined before 1/1/2015");
             Console.WriteLine();
            result = employees.Where (s => s.DOJ < Convert.ToDateTime("01/01/2015")).ToList();
              foreach (var item in result)
                  Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
              Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task F : Display a list of all the employee whose date of birth is after 1/1/1990");
            Console.WriteLine();
            result = employees.Where(s => s.DOB > Convert.ToDateTime("01/01/1990")).ToList();
            foreach (var item in result)
                  Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task G : Display a list of all the employee whose designation is Consultant and Associate");
            Console.WriteLine();
            result = from s in employees
                     where s.Title == "Consultant" || s.Title == "Associate"
                     select s;
            foreach (var item in result)
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task H : Display total number of employees");
            Console.WriteLine();
            int i = 0;
            result = from s in employees
                     select s;
            foreach (var item in result)
            {
                i++;
            }
            Console.WriteLine("Totla Numbers of Employees :"+ i);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task I : Display total number of employees belonging to “Chennai”");
            Console.WriteLine();
            int j = 0;
            result = from s in employees
                     where s.City == "Chennai"
                     select s;
            foreach (var item in result)
            {
                j++;
            }
            Console.WriteLine("Total Numbers of Employees who belongs to Chennai : "+ j);
                //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task J : Display highest employee id from the list");
            Console.WriteLine();
            result = from s in employees
                     where s.EmployeeID == 1010
                     select s;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task K : Display total number of employee who have joined after 1/1/2015");
            Console.WriteLine();
            result = employees.Where(s => s.DOJ > Convert.ToDateTime("01/01/2015")).ToList();
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Task L : Display total number of employee whose designation is not “Associate”");
            Console.WriteLine();
            result = from s in employees
                     where s.Title != "Associate"
                     select s;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Task M : Display total number of employee based on City");
            Console.WriteLine();
            result =  employees.OrderBy(s => s.City).ToList();
             foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            /* Console.WriteLine("Task N : n.Display total number of employee based on city and title");
             Console.WriteLine();
            result = (from i in employees group i by i.City)
                 foreach (var item in result)
                 Console.WriteLine(item.key);*/
            //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
            Console.WriteLine();


            /*Console.WriteLine("Task O : Display total number of employee who is youngest in the list");
             Console.WriteLine();
            result = employees.DOB;
            foreach (var item in result)
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", item.EmployeeID, item.FirstName, item.LastName, item.Title, item.DOB, item.DOJ, item.City);
            Console.WriteLine();
             Console.WriteLine();
*/

            Console.ReadKey();
        }
    }
}
