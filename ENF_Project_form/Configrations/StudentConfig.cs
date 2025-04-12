using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENF_Project_form
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
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
