using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENF_Project_form.Configrations
{
    public class CourseSessionConfig : IEntityTypeConfiguration<CourseSession>
    {
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.Property(p => p.Title)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
        }
    }
}
