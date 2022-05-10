using System;
using System.Collections.Generic;

#nullable disable

namespace LabAssignmentEFCore.Models
{
    public partial class Agent
    {
        public Agent()
        {
            Custs = new HashSet<Cust>();
            Orders = new HashSet<Order>();
        }

        public string AgentCode { get; set; }
        public string AgentName { get; set; }
        public string WorkingArea { get; set; }
        public string Commission { get; set; }
        public string PhoneNo { get; set; }
        public string AgentCountry { get; set; }

        public virtual ICollection<Cust> Custs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
