

namespace ENF_Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int? Duration { get; set; } = 0;
        public string? Name { get; set; } = string.Empty;
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
        public int? InstructorId { get; set; }
        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<CourseSession> Sessions { get; set; } = new HashSet<CourseSession>();
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
