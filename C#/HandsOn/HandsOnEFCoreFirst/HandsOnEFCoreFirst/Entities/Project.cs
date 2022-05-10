using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFCoreFirst.Entities
{
    class Project
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int TeamSize { get; set; }
    }
}
