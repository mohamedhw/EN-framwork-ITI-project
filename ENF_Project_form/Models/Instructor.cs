using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENF_Project_form.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        [ForeignKey("Manager")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; } = null;
        public virtual Department? ManagedDepartment { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSession> Sessions { get; set; } = new HashSet<CourseSession>();

    }
}
