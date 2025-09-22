using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Models
{
    //[Table("Employeetable")]


    public class Employee
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "")]
        [Length(10, 5)]
        public string? Name { get; set; }
        
        [Range(18, 60)]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [NotMapped]
        public int Test { get; set; }        
        public string Address { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
