using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_07
{
    public class Contact_01
    {
        public long ContactNo { get; set; }
        public string ContactName { get; set; }
        public string CellNo { get; set; }

        public override string ToString() => $"Contact (No: {ContactNo}, Name: {ContactName}, Cell No: {CellNo})";
    }
}
