using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENF_Project_form.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int? Duration { get; set; } = 0;
        public string? Name { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

        public virtual ICollection<CourseSession> Sessions { get; set; } = new HashSet<CourseSession>();
    }
}
