using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using ENF_Project_form.Models;
using ENF_Project_form.Configrations;

namespace ENF_Project_form.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KIM;DataBase=ENFProject;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(i => i.ManagedDepartment)
                .HasForeignKey<Department>(d => d.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<CourseSession>()
                .HasOne(cs => cs.Instructor)
                .WithMany(i => i.Sessions)
                .HasForeignKey(cs => cs.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new InstructorConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new CourseSessionConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new CourseSessionAttendanceConfig());



            var _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, FirstName = "Alice", LastName = "Anderson", Phone = "111-1111", DepartmentId = 1},
                new Instructor { Id = 2, FirstName = "Bob", LastName = "Brown", Phone = "222-2222", DepartmentId = 2},
                new Instructor { Id = 3, FirstName = "Charlie", LastName = "Clark", Phone = "333-3333", DepartmentId = 3 }
            };


            var _departments = new List<Department>
            {
                new Department { Id = 1, Name = "Computer Science", Location = "Building A", ManagerId=null },
                new Department { Id = 2, Name = "Mathematics", Location = "Building B", ManagerId=null  },
                new Department { Id = 3, Name = "Physics", Location = "Building C", ManagerId=null }
            };




            var _courses = new List<Course>
            {
                new Course { Id = 1, Name = "Intro to Programming", Duration = 40, DepartmentId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Advanced Algorithms", Duration = 60, DepartmentId = 1, InstructorId = 1 },
                new Course { Id = 3, Name = "Calculus I", Duration = 45, DepartmentId = 2, InstructorId = 2 },
                new Course { Id = 4, Name = "Physics I", Duration = 50, DepartmentId = 3, InstructorId = 3 }
            };

            var _students = new List<Student>
            {
                new Student { Id = 1, FirstName = "John", LastName = "Doe", Phone = "444-4444" },
                new Student { Id = 2, FirstName = "Jane", LastName = "Smith", Phone = "555-5555" },
                new Student { Id = 3, FirstName = "Mike", LastName = "Johnson", Phone = "666-6666" }
            };

            var _sessions = new List<CourseSession>
            {
                new CourseSession { Id = 1, Date = new DateTime(2023, 10, 1), Title = "Introduction to C#", CourseId = 1, InstructorId = 1 },
                new CourseSession { Id = 2, Date = new DateTime(2023, 10, 8), Title = "Data Structures", CourseId = 2, InstructorId = 1 },
                new CourseSession { Id = 3, Date = new DateTime(2023, 10, 15), Title = "Calculus I", CourseId = 3, InstructorId = 2 },
                new CourseSession { Id = 4, Date = new DateTime(2023, 10, 22), Title = "Physics I", CourseId = 4, InstructorId = 3 }
            };

            var _attendances = new List<CourseSessionAttendance>
            {
                new CourseSessionAttendance {Id= 1, CourseSessionId = 1, StudentId = 1, Grade = 85, Notes = "Active participation" },
                new CourseSessionAttendance {Id= 2, CourseSessionId = 1, StudentId = 2, Grade = 90, Notes = "Excellent work" }
            };

            var _studentCourse= new List<StudentCourse>
            {
                new StudentCourse { StudentId=1, CourseId=1},
                new StudentCourse { StudentId=2, CourseId=2 },
                new StudentCourse { StudentId=2, CourseId=1}
            };

            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Department>().HasData(_departments);
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Instructor>().HasData(_instructors);


            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse");

            modelBuilder.Entity<Course>().HasData(_courses);
            modelBuilder.Entity<Student>().HasData(_students);
            modelBuilder.Entity<CourseSession>().HasData(_sessions);
            modelBuilder.Entity<CourseSessionAttendance>().HasData(_attendances);
            modelBuilder.Entity<StudentCourse>().HasData(_studentCourse);


        }
        public override int SaveChanges()
        {
            ValidateEntities();
            return base.SaveChanges();
        }
        private void ValidateEntities()
        {
            var entities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
                .Select(e => e.Entity);

            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext, validateAllProperties: true);
            }
        }

        


    }
}
