using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertinceMapping.Models
{
    public class FulltimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}
