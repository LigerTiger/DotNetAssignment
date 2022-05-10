using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnEFCoreFirst.Entities
{
    [Table("Employee")]
    class Employee
    {
        [Key] // DECLARE ID AS PRIMARY KEY COLUMN WITH IDENTITY 1,1 APPLIED
        public  int Id { get; set; }
        [Required] // NOT NULL IS APPLIED
        [StringLength(30)] //length is 30 applied 
        [Column(TypeName ="Varchar")]
        public string Name { get; set; }
        [Column(TypeName ="Date")]
        public DateTime JoinDate { get; set; }
        public double? Salary { get; set; }

        [ForeignKey("Project")]
        public string ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
