using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyOefening.Models
{
    public class Department
    {
        [Key]
        [Column("DepartmentNr")]
        public int DepartmentID { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum lenght is 50 chars")]
        [Display(Name = "Departement Name")]
        public string Name { get; set; }
        
    }
}
