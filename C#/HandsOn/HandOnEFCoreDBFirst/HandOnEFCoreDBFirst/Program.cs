using System;
using System.Linq;
using System.Collections.Generic;
using HandOnEFCoreDBFirst.Models;

namespace HandOnEFCoreDBFirst
{
    class Program
    {
        public static void GetAllEmployee()
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                List<Employee> list = (from e in db.Employees
                                       select e).ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} ", item.EmpId, item.EmpName, item.EmailId, item.JoinDate.ToShortDateString(), item.DeptId);
                }
            }

        }
        public static void GetEmployee(int eid)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                Employee item = db.Employees.SingleOrDefault(e => e.EmpId == eid);
                /*employee = (from e in db.Employee
                            where e.EmpId == eid
                            select e).SingleOrDEfault();

                */
                if (item != null)
                    Console.WriteLine("{0} {1} {2} {3} {4} ", item.EmpId, item.EmpName, item.EmailId, item.JoinDate.ToShortDateString(), item.Salary);
                else
                    Console.WriteLine("Invalid Id");
            }

        }
        public static void GetEmployeeByDeptId(string deptid)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                List<Employee> employees = (from e in db.Employees
                                            where e.DeptId == deptid
                                            select e).ToList();
                //employee db.Employees.Where (e=> e.DeptID==deptid).ToList();
                foreach (var item in employees)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} ", item.EmpId, item.EmpName, item.EmailId, item.JoinDate.ToShortDateString(), item.DeptId);

                }
            }
        }
        public static void AddEmployee(Employee employee)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges(); // To save the new record in employee table 
            }
        }
        public static void EditEmployee(Employee employee)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                db.Employees.Update(employee);
                db.SaveChanges(); // To save the new record in employee table 
            }
        }
        public static void DeleteEmployee(int eid) // Delete
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                Employee employee = db.Employees.Single(e => e.EmpId == eid);
                db.Employees.Remove(employee);
                db.SaveChanges(); // To save the new record in employee table 
            }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                EmpId = 45052,
                EmpName = "Sajid Tanvir",
                JoinDate = DateTime.Parse("11.03.2022"),
                DeptId = "D002",
                EmailId = "sajid012@gmail.com",
                Salary = 45200,
                Mobile = "7856652641"

            };

            //AddEmployee(employee);
            //DeleteEmployee(45009);
            //EditEmployee(employee);
            //GetAllEmployee();

            //Console.WriteLine("Enter ID");
            //int eid = int.Parse(Console.ReadLine());
            //GetEmployee(eid);
            /*Console.WriteLine("Enter Dept ID");
            string did = Console.ReadLine();
            GetEmployeeByDeptId(did);*/


            //Departmet Table 



            Dept dept = new Dept()
            {
                DeptId = "D003",
                DeptName = "Tech Supports",
                Location = "Pune"
            };
           // AddDept(dept);

            Console.WriteLine("Enter Dept ID");
            string did = Console.ReadLine();
            GetDeptById(did);

            // DELETE OPERATION 
            // Console.WriteLine("Enter the Dept ID");
            // string depid = Console.ReadLine();
            //DeleteDept(depid); // Can't Delete because of FK 

            //EDIT DEPATRMENT BY NAME AND ID
            
            /*Console.WriteLine("Enter DeptId and DeptName: ");
            
            var deptId = Console.ReadLine();
            var deptName = Console.ReadLine();
            EditDeptNameById(deptId, deptName);*/

            GetAllDepetment();






        }

        // DEPARTMENT TABLE 

        public static void GetAllDepetment()
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                List<Dept> list = (from e in db.Depts
                                   select e).ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("{0} {1} {2}", item.DeptId, item.DeptName, item.Location);
                }
            }
        }
        public static void GetDeptById(string deptId)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                List<Dept> depts = (from e in db.Depts
                                    where e.DeptId == deptId
                                    select e).ToList();
                
                foreach (var item in depts)
                {
                    Console.WriteLine("{0} {1} {2} ", item.DeptId, item.DeptName, item.Location);

                }
            }
        }
        public static void AddDept(Dept dept)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                db.Depts.Add(dept);
                db.SaveChanges(); // To save the new record in dept table 
            }
        }
        public static void DeleteDept(string deptId) // Delete
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                Dept dept = db.Depts.Single(d => d.DeptId == deptId);
                db.Depts.Remove(dept);
                db.SaveChanges(); 
            }
        }

        public static void EditDeptNameById(string deptId, string deptName)
        {
            using (Batch1DBContext db = new Batch1DBContext())
            {
                Dept dept = db.Depts.Where(d => d.DeptId == deptId).Single();
                dept.DeptName = deptName;
                db.Depts.Update(dept);
                db.SaveChanges();
                    
               // db.Depts.UpdateRange(deptid, deptname);
               //db.SaveChanges(); 
            }
        }


    }

}
