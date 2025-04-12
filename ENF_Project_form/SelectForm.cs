using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ENF_Project_form
{
    public partial class SelectForm : Form
    {
        private string _tableName;
        private MyContext db = new MyContext();
        public SelectForm(string tableName)
        {
            InitializeComponent();
            _tableName = tableName;
            switch (_tableName) {
                case "student":
                    db.Students.Load();
                    var students = db.Students.Select(s => new { s.Id, s.FirstName, s.LastName, s.Phone }).ToList();
                    Table_Data.DataSource = students;
                    break;
                case "course":
                    db.Courses.Include(c => c.Department).Include(c => c.Instructor) .Load();
                    var courses = db.Courses.Select(c => new { c.Id, c.Duration, c.Name, DepartmentName = c.Department.Name, Instructor = $"{c.Instructor.FirstName} {c.Instructor.LastName}" }).ToList();
                    Table_Data.DataSource = courses;
                    break;
                case "department":
                    db.Departments.Include(d => d.Manager).Load();
                    var departments = db.Departments.Select(d => new { d.Id, d.Name, Manager = $"{d.Manager.FirstName} {d.Manager.LastName}"}).ToList();
                    Table_Data.DataSource = departments;
                    break;
                case "Instructor":
                    db.Instructors.Include(i => i.Department).Load();
                    var instructors = db.Instructors.Select(i => new { i.Id, i.FirstName, i.LastName, i.Phone, Department = i.Department.Name }).ToList();
                    Table_Data.DataSource = instructors;
                    break;
                case "CourseSession":
                    db.CourseSessions.Include(c=>c.Course).Include(c=>c.Instructor).Load();
                    var couseSessions = db.CourseSessions.Select(c=> new { c.Id, c.Title, Course = c.Course.Name, Instructor = $"{c.Instructor.FirstName} {c.Instructor.LastName}", c.Date}).ToList();
                    Table_Data.DataSource = couseSessions;
                    break;
                case "CourseSessionAttendance":
                    db.CourseSessionAttendances.Include(c=>c.CourseSession).Include(c=>c.Student).Load();
                    var courseSessionAttendances = db.CourseSessionAttendances.Select(c => new { c.Id, Session = c.CourseSession.Title, Student = $"{c.Student.FirstName} {c.Student.LastName}", c.Grade, c.Notes}).ToList();
                    Table_Data.DataSource = courseSessionAttendances;
                    break;
                case "StudentCourse":
                    db.StudentCourses.Include(c => c.Course).Include(c => c.Student).Load();
                    var studentCourses = db.StudentCourses.Select(c => new { c.CourseId, c.StudentId, Student = $"{c.Student.FirstName} {c.Student.LastName}", Course = c.Course.Name }).ToList();
                    Table_Data.DataSource = studentCourses;
                    break;
            }

        }

        private void Table_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
