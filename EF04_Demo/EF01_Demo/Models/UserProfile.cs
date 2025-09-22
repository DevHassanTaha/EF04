using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Bio { get; set; }
        //[ForeignKey("User")]
        public int FKUserId { get; set; }
        public virtual User User { get; set; }
        
    }
}
