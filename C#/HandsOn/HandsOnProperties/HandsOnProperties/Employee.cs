using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{

    class Employee
    {
        public int eid;
        public string ename;
        public int EID
        {
            get { return eid; }
            set
            {
                if (value >= 0)
                    eid = value;
                else
                {
                    Console.WriteLine("Invalid Id");
                }
            }
        }
        public string NAME
        {
            get { return ename; }
            set
            {
                if (value != null)
                    ename = value;
                else
                {
                    Console.WriteLine("Name shoiuld not be null");

                }
                    
            }
        }
        public void Details()
        {
            Console.WriteLine("ID:{0} Name: {1}", eid, ename);
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            
            e1.EID= -303;
            e1.NAME= null;
            e1.Details();
            Employee e2 = new Employee();
            e2.EID = 3243;
            e2.NAME = "Ankit";
            e2.Details();

        }

    }
}
