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
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            builder.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
        }
    }
}
