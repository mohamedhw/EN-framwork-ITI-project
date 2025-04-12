using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENF_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ENF_Project.Models;

namespace ENF_Project.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instances { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
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
                .HasForeignKey<Department>(i => i.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Instructor>()
            //    .HasOne(i => i.ManagedDepartment)
            //    .WithOne(d => d.Manager)
            //    .HasForeignKey<Department>(d => d.ManagerId);

            //modelBuilder.Entity<Instructor>()
            //    .HasOne(i => i.Department)
            //    .WithMany(d => d.Instructors)
            //    .HasForeignKey(i => i.DepartmentId);

            //modelBuilder.Entity<Course>()
            //    .HasOne(c => c.Department)
            //    .WithMany(d => d.Courses)
            //    .HasForeignKey(c => c.DepartmentId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Course>()
            //    .HasOne(c => c.Instructor)
            //    .WithMany(i => i.Courses)
            //    .HasForeignKey(c => c.InstructorId)
            //    .OnDelete(DeleteBehavior.NoAction);


            var _departments = new List<Department>
            {
                new Department { Id = 1, Name = "Computer Science", Location = "Building A" },
                new Department { Id = 2, Name = "Mathematics", Location = "Building B" },
                new Department { Id = 3, Name = "Physics", Location = "Building C" }
            };

            var _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, FirstName = "Alice", LastName = "Anderson", Phone = "111-1111", DepartmentId = 1 },
                new Instructor { Id = 2, FirstName = "Bob", LastName = "Brown", Phone = "222-2222", DepartmentId = 2 },
                new Instructor { Id = 3, FirstName = "Charlie", LastName = "Clark", Phone = "333-3333", DepartmentId = 3 }
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


            modelBuilder.Entity<Department>().HasData(_departments);
            modelBuilder.Entity<Instructor>().HasData(_instructors);
            modelBuilder.Entity<Course>().HasData(_courses);
            modelBuilder.Entity<Student>().HasData(_students);
            modelBuilder.Entity<CourseSession>().HasData(_sessions);
            modelBuilder.Entity<CourseSessionAttendance>().HasData(_attendances);

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
        public void SeedData()
        {
            using (var transaction = Database.BeginTransaction())
            {
                var instructor = new Instructor
                {
                    FirstName = "Alice",
                    LastName = "Anderson",
                    Phone = "111-1111"
                };
                Instances.Add(instructor);
                SaveChanges();

                var csDepartment = new Department
                {
                    Name = "Computer Science",
                    Location = "Building A",
                    ManagerId = instructor.Id
                };
                Departments.Add(csDepartment);
                SaveChanges();

                instructor.DepartmentId = instructor.Id;
                SaveChanges();

                // Seed Math Department
                var mathInstructor = new Instructor
                {
                    FirstName = "Bob",
                    LastName = "Brown",
                    Phone = "222-2222"
                };
                Instances.Add(mathInstructor);
                SaveChanges();

                var mathDepartment = new Department
                {
                    Name = "Mathematics",
                    Location = "Building B",
                    ManagerId = mathInstructor.Id
                };
                Departments.Add(mathDepartment);
                SaveChanges();

                mathInstructor.DepartmentId = mathDepartment.Id;
                SaveChanges();

                var courses = new List<Course>
                {
                    new Course
                    {
                        Name = "Intro to Programming",
                        Duration = 40,
                        DepartmentId = csDepartment.Id,
                        InstructorId = instructor.Id
                    },
                    new Course
                    {
                        Name = "Advanced Algorithms",
                        Duration = 60,
                        DepartmentId = csDepartment.Id,
                        InstructorId = instructor.Id
                    },
                    new Course
                    {
                        Name = "Calculus I",
                        Duration = 45,
                        DepartmentId = mathDepartment.Id,
                        InstructorId = mathInstructor.Id
                    }
                };
                Courses.AddRange(courses);
                SaveChanges();

                var students = new List<Student>
                {
                    new Student { FirstName = "John", LastName = "Doe", Phone = "333-3333" },
                    new Student { FirstName = "Jane", LastName = "Smith", Phone = "444-4444" },
                    new Student { FirstName = "Mike", LastName = "Johnson", Phone = "555-5555" }
                };
                Students.AddRange(students);
                SaveChanges();



                var sessions = new List<CourseSession>
                {
                    new CourseSession
                    {
                        Date = new DateTime(2023, 10, 1),
                        Title = "Introduction to C#",
                        CourseId = courses[0].Id,
                        InstructorId = instructor.Id
                    },
                    new CourseSession
                    {
                        Date = new DateTime(2023, 10, 8),
                        Title = "Data Structures",
                        CourseId = courses[1].Id,
                        InstructorId = instructor.Id
                    }
                };
                CourseSessions.AddRange(sessions);
                SaveChanges();

                var attendances = new List<CourseSessionAttendance>
                {
                    new CourseSessionAttendance
                    {
                        CourseSessionId = sessions[0].Id,
                        StudentId = students[0].Id,
                        Grade = 85,
                        Notes = "Active participation"
                    },
                    new CourseSessionAttendance
                    {
                        CourseSessionId = sessions[0].Id,
                        StudentId = students[1].Id,
                        Grade = 90,
                        Notes = "Excellent work"
                    }
                };
                CourseSessionAttendances.AddRange(attendances);
                SaveChanges();

                transaction.Commit();

            }
        }


    }
}
