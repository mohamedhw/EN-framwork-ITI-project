using System.Data;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ENF_Project_form
{
    public partial class StudentCourseForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();
        public StudentCourseForm(string operation)
        {
            InitializeComponent();
            _operation = operation;

            LoadStudentsComboBox();
            LoadCoursesComboBox();
            SelectBox.SelectionMode = SelectionMode.MultiExtended;

            studentsBox.SelectedIndexChanged += StudentsBox_SelectedIndexChanged;
            coursesBox.SelectedIndexChanged += CoursesBox_SelectedIndexChanged;

            if (operation == "update" || operation == "delete")
            {
                studentCourseBox.Enabled = true;
                fillData();

            }
            if (operation == "delete")
            {
                disapleForm();
            }
        }
        private void disapleForm()
        {
            studentsBox.Enabled = false;
            coursesBox.Enabled = false;
            SelectBox.Enabled = false;
        }

        private void LoadStudentsComboBox()
        {
            var students = db.Students
                .OrderBy(s => s.LastName)
                .Select(s => new { Id = s.Id, FullName = s.FirstName + " " + s.LastName })
                .ToList();

            students.Insert(0, new { Id = -1, FullName = "Select a Student" });


            studentsBox.DataSource = students;
            studentsBox.DisplayMember = "FullName";
            studentsBox.ValueMember = "Id";
            studentsBox.SelectedIndex = 0;

        }

        private void LoadCoursesComboBox()
        {
            var courses = db.Courses
                .OrderBy(c => c.Name)
                .Select(c => new { Id = c.Id, Name = c.Name })
                .ToList();

            courses.Insert(0, new { Id = -1, Name = "Select a Course" });

            coursesBox.DataSource = courses;
            coursesBox.DisplayMember = "Name";
            coursesBox.ValueMember = "Id";
            coursesBox.SelectedIndex = 0;
        }
        public class StudentCourseDisplayItem
        {
            public int StudentId { get; set; }
            public int CourseId { get; set; }
            public string DisplayText { get; set; }
        }


        private void LoadStudentsBox()
        {
            var students = db.Students
                .OrderBy(s => s.LastName)
                .Select(s => new {
                    s.Id,
                    FullName = s.FirstName + " " + s.LastName
                })
                .ToList();
            SelectBox.DataSource = students;
            SelectBox.DisplayMember = "FullName";
            SelectBox.ValueMember = "Id";
        }
        private void LoadCourseBox()
        {
            var courses = db.Students.ToList();
            SelectBox.DataSource = courses;
            SelectBox.DisplayMember = "FullName";
            SelectBox.ValueMember = "Id";
        }

        private void fillData()
        {
            if (studentCourseBox.SelectedValue == null) return;

            dynamic selectedItem = studentCourseBox.SelectedItem;
            int studentId = selectedItem.StudentId;
            int courseId = selectedItem.CourseId;

            var studentCourse = db.StudentCourses.Find(studentId, courseId);

            var course = db.Courses.Find(studentCourse.CourseId);
            var student = db.Students.Find(studentCourse.StudentId);

            if (course != null)
            {
                SelectBox.Text = course.Name;
            }
            if (student != null)
            {
                studentsBox.Text = $"{student.FirstName} {student.LastName}";
            }

        }

        private bool updatingSelections = false;


        private void StudentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsBox.SelectedValue == null) return;

            int studentId = (int)studentsBox.SelectedValue;

            if (studentId == -1)
            {
                coursesBox.Enabled = true;
                SelectBox.DataSource = null;
                return;
            }


            coursesBox.Enabled = false;
            studentsBox.Enabled = true;
            Submit.Enabled = true;
            SelectBox.Enabled = true;

            var allCourses = db.Courses
                .OrderBy(c => c.Name)
                .Select(c => new { c.Id, c.Name })
                .ToList();

            var enrolledCourseIds = db.StudentCourses
                .Where(sc => sc.StudentId == studentId)
                .Select(sc => sc.CourseId)
                .ToList();

            SelectBox.DataSource = allCourses;
            SelectBox.DisplayMember = "Name";
            SelectBox.ValueMember = "Id";

            for (int i = 0; i < allCourses.Count; i++)
            {
                SelectBox.SetSelected(i, enrolledCourseIds.Contains(allCourses[i].Id));
            }
        }

        private void CoursesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coursesBox.SelectedValue == null) return;

            int courseId = (int)coursesBox.SelectedValue;

            if (courseId == -1)
            {
                studentsBox.Enabled = true;
                SelectBox.DataSource = null;
                return;
            }


            studentsBox.Enabled = false;
            coursesBox.Enabled = true;
            Submit.Enabled = true;
            SelectBox.Enabled = true;


            var allStudents = db.Students
                .OrderBy(s => s.LastName)
                .Select(s => new { s.Id, FullName = s.FirstName + " " + s.LastName })
                .ToList();

            var enrolledStudentIds = db.StudentCourses
                .Where(sc => sc.CourseId == courseId)
                .Select(sc => sc.StudentId)
                .ToList();

            SelectBox.DataSource = allStudents;
            SelectBox.DisplayMember = "FullName";
            SelectBox.ValueMember = "Id";

            for (int i = 0; i < allStudents.Count; i++)
            {
                SelectBox.SetSelected(i, enrolledStudentIds.Contains(allStudents[i].Id));
            }
        }



        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentCourseBox.SelectedItem is StudentCourseDisplayItem selected)
            {
                int studentId = selected.StudentId;
                int courseId = selected.CourseId;
            }
            fillData();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (_operation == "add")
            {
                add();
            }
        }


        private void add()
        {

            try
            {
                if (studentsBox.Enabled && studentsBox.SelectedItem != null)
                {
                    int studentId = (int)studentsBox.SelectedValue;
                    var selectedCourses = SelectBox.SelectedItems.Cast<dynamic>()
                        .Select(c => (int)c.Id).ToList();

                    // Get
                    var existingEnrollments = db.StudentCourses
                        .Where(sc => sc.StudentId == studentId)
                        .Select(sc => sc.CourseId)
                        .ToList();

                    // Add
                    foreach (int courseId in selectedCourses.Where(c => !existingEnrollments.Contains(c)))
                    {
                        db.StudentCourses.Add(new StudentCourse
                        {
                            StudentId = studentId,
                            CourseId = courseId
                        });
                    }

                    // Remove
                    foreach (int courseId in existingEnrollments.Where(c => !selectedCourses.Contains(c)))
                    {
                        var enrollment = db.StudentCourses
                            .First(sc => sc.StudentId == studentId && sc.CourseId == courseId);
                        db.StudentCourses.Remove(enrollment);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Student's courses updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (coursesBox.Enabled && coursesBox.SelectedItem != null)
                {
                    int courseId = (int)coursesBox.SelectedValue;
                    var selectedStudents = SelectBox.SelectedItems.Cast<dynamic>()
                        .Select(s => (int)s.Id).ToList();

                    // Get
                    var existingEnrollments = db.StudentCourses
                        .Where(sc => sc.CourseId == courseId)
                        .Select(sc => sc.StudentId)
                        .ToList();

                    // Add
                    foreach (int studentId in selectedStudents.Where(s => !existingEnrollments.Contains(s)))
                    {
                        db.StudentCourses.Add(new StudentCourse
                        {
                            StudentId = studentId,
                            CourseId = courseId
                        });
                    }

                    // Remove
                    foreach (int studentId in existingEnrollments.Where(s => !selectedStudents.Contains(s)))
                    {
                        var enrollment = db.StudentCourses
                            .First(sc => sc.StudentId == studentId && sc.CourseId == courseId);
                        db.StudentCourses.Remove(enrollment);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Course's students updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a student or a course first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void StudentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentId = (int)studentsBox.SelectedValue;
        }

        private void StudentCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
