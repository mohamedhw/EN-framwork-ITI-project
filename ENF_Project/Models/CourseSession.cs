

namespace ENF_Project.Models
{
    public class CourseSession
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor? Instructor { get; set; }
        public int? CourseId { get; set; }
        public virtual Course? Course { get; set; }
        public virtual ICollection<CourseSessionAttendance> Attendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
