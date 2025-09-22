using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Models
{
    //[PrimaryKey(nameof(CourseId),nameof(StudentId))]
    public class StudentCourse
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int Grade { get; set; }
    }
}
