using System;
using System.Collections.Generic;

#nullable disable

namespace HandOnEFCoreDBFirst.Models
{
    public partial class Student
    {
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? StudentDob { get; set; }
        public string City { get; set; }
        public string StudentAddress { get; set; }
    }
}
