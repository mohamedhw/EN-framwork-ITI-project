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
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            builder.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            builder.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
        }
    }
}
