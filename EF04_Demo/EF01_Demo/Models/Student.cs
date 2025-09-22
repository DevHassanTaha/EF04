using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public ICollection<Course> Courses { get; set; }
        public virtual ICollection<StudentCourse> studentCourses {  get; set; } 

    }
}
