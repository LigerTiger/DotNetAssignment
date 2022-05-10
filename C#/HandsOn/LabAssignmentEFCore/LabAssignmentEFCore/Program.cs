using System;
using System.Linq;
using System.Collections.Generic;
using LabAssignmentEFCore.Models;

namespace LabAssignmentEFCore
{
    class Program
    {
        public static void  ShowAllAgent()
        {
            using (CustomerContext db = new CustomerContext())
            {
                List<Agent> list = (from e in db.Agents
                                    select e).ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.AgentCode, item.AgentName, item.WorkingArea, item.Commission, item.PhoneNo, item.AgentCountry);
                }
            }

        }
        public static void voidShowAllOrder()
        {
            using (CustomerContext db = new CustomerContext())
            {
                List<Order> list = (from e in db.Orders
                                   select e).ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}",item.OrderNo,item.OrderAmount,item.AdvanceAmount,item.OrderDate,item.CustCode,item.AgentCode,item.OrderDescription,item.AgentCodeNavigation);
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Details of All Orders\n");
            voidShowAllOrder();
            Console.WriteLine("Details of All Agents\n");
            ShowAllAgent();


        }
    }
}
