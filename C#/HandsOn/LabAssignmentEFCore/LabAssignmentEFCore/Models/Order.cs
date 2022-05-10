using System;
using System.Collections.Generic;

#nullable disable

namespace LabAssignmentEFCore.Models
{
    public partial class Order
    {
        public int OrderNo { get; set; }
        public int OrderAmount { get; set; }
        public int? AdvanceAmount { get; set; }
        public DateTime? OrderDate { get; set; }
        public int CustCode { get; set; }
        public string AgentCode { get; set; }
        public string OrderDescription { get; set; }

        public virtual Agent AgentCodeNavigation { get; set; }
    }
}
