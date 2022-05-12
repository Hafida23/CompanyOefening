using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyOefening.Models
{
    public class Project
    {
        [Key]
        [Column("ProjectNr ")]
        public int ProjectID { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum lenght is 50 chars")]
        [Display(Name = "Project Name")]
        public string Name { get; set; }
    }
}
