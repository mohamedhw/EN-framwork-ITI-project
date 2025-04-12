using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENF_Project_form.Models
{
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Location { get; set; } = string.Empty;
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public virtual Instructor? Manager { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
