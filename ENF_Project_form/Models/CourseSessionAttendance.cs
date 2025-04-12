using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENF_Project_form.Models
{
    public class CourseSessionAttendance
    {
        public int Id { get; set; }
        public int CourseSessionId { get; set; }
        public virtual CourseSession CourseSession { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int? Grade { get; set; }
        public string? Notes { get; set; }
    }
}
