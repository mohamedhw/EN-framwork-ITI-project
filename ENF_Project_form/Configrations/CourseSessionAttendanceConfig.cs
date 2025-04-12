using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENF_Project_form.Configrations
{
    public class CourseSessionAttendanceConfig : IEntityTypeConfiguration<CourseSessionAttendance>
    {
        public void Configure(EntityTypeBuilder<CourseSessionAttendance> builder)
        {


        }
    }
}
