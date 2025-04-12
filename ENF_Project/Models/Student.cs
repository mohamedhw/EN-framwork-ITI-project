

namespace ENF_Project.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSessionAttendance> Attendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
