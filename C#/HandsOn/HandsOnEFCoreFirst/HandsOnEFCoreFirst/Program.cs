using System;
using HandsOnEFCoreFirst.Entities;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCoreFirst
{
    class Program
    {
        public static void AddEmployee(Employee employee)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }
        public static void EditEmployee(Employee employee)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Employees.Update(employee);
                db.SaveChanges();
            }
        }
        public static void GetAllEmployees()
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                List<Employee> list = db.Employees.ToList();
                foreach(var item in list)
                {
                    Console.WriteLine("{0} {1} {2} {3}",item.Id,item.Name,item.JoinDate,item.Salary);
                }
            }
        }
        public static void GetEmployeeById(int eid)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Employee item = db.Employees.SingleOrDefault(e => e.Id == eid);
                if(item != null)
                    Console.WriteLine("{0} {1} {2} {3} ", item.Id, item.Name, item.JoinDate, item.Salary);
                else
                    Console.WriteLine("Invaild Id");
            }
        }
        public static void DeleteEmployee(int eid)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Employee item = db.Employees.SingleOrDefault(e => e.Id == eid);
                db.Employees.Remove(item);
                db.SaveChanges();
               
            }
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                JoinDate = DateTime.Parse("21.2.2022"),
                Salary = 32000,
                Name = "Amit"
            };
            //AddEmployee(e1);
            //EditEmployee(e1);
            //DeleteEmployee(5);
            
            GetAllEmployees();
            Console.WriteLine("Details of Employees ");
            GetEmployeeById(2);

        }
    }
}
