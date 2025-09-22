using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<Student> students { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
