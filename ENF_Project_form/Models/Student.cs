

namespace ENF_Project_form.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        public virtual ICollection<CourseSessionAttendance> Attendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
