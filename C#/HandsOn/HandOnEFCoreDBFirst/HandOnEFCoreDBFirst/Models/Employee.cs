using System;
using System.Collections.Generic;

#nullable disable

namespace HandOnEFCoreDBFirst.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public DateTime JoinDate { get; set; }
        public int? Salary { get; set; }
        public string DeptId { get; set; }

        public virtual Dept Dept { get; set; }
    }
}
