using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyOefening.Models
{
    public class Employee
    {
        [Key]
        [Column("EmployeeNr ")]
        public int EmployeeID { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum lenght is 50 chars")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
        
    }
}
