using System;
using System.Collections.Generic;

#nullable disable

namespace LabAssignmentEFCore.Models
{
    public partial class Cust
    {
        public int CustCode { get; set; }
        public string CustName { get; set; }
        public string CustCity { get; set; }
        public string WorkingArea { get; set; }
        public string CustCountry { get; set; }
        public string Grade { get; set; }
        public int OpeningAmount { get; set; }
        public int ReceiveAmount { get; set; }
        public int PaymentAmount { get; set; }
        public int OutstandingAmount { get; set; }
        public string PhoneNo { get; set; }
        public string AgentCode { get; set; }

        public virtual Agent AgentCodeNavigation { get; set; }
    }
}
