
using System.ComponentModel.DataAnnotations.Schema;

namespace ENF_Project.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual Department ManagedDepartment { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSession> Sessions { get; set; } = new HashSet<CourseSession>();

    }
}
