using System.Data;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;

namespace ENF_Project_form
{
    public partial class CourseForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();
        public CourseForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            LoadInstructorComboBox();
            LoadDepartmentComboBox();
            if (operation == "update" || operation == "delete")
            {
                CoursesBox.Enabled = true;
                LoadCoursesComboBox();
                fillData();

            }
            if (operation == "delete")
            {
                disapleForm();
            }
        }




        private void disapleForm()
        {
            NameBox.Enabled = false;
            DurationBox.Enabled = false;
            DepartmentBox.Enabled = false;
            InstructorBox.Enabled = false;
        }

        private void LoadCoursesComboBox()
        {
            var context = new MyContext();
            var courses = context.Courses
            .OrderBy(i => i.Name)
            .Select(i => new
            {
                i.Id,
                i.Name
            })
            .ToList();

            CoursesBox.DataSource = courses;
            CoursesBox.DisplayMember = "Name";
            CoursesBox.ValueMember = "Id";
            CoursesBox.Refresh();

        }
        private void LoadDepartmentComboBox()
        {
            var context = new MyContext();
            var departments = context.Departments.Select(i => new { i.Id, i.Name }).ToList();
            DepartmentBox.DataSource = departments;
            DepartmentBox.DisplayMember = "Name";
            DepartmentBox.ValueMember = "Id";
            DepartmentBox.Refresh();
        }
        private void LoadInstructorComboBox()
        {
            var context2 = new MyContext();
            var instractors = context2.Instructors.Select(i => new { i.Id, FullName = $"{i.FirstName} {i.LastName}" }).ToList();
            InstructorBox.DataSource = instractors;
            InstructorBox.DisplayMember = "FullName";
            InstructorBox.ValueMember = "Id";
            InstructorBox.Refresh();
        }
        private void fillData()
        {
            if (CoursesBox.SelectedValue == null) return;

            int courseId = (int)CoursesBox.SelectedValue;
            var course = db.Courses.Find(courseId);

            var department = db.Departments.Find(course.DepartmentId);
            var instructor = db.Instructors.Find(course.InstructorId);

            if (department != null)
            {
                DepartmentBox.Text = department.Name;
            }
            if (instructor != null)
            {
                InstructorBox.Text = $"{instructor.FirstName} {instructor.LastName}";
            }
            NameBox.Text = course.Name;
            DurationBox.Text = course.Duration.ToString();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (_operation == "add")
            {
                add();
            }
            else if (_operation == "update")
            {
                update();
            }
            else if (_operation == "delete")
            {
                delete();
            }
        }


        private void add()
        {
            string durationText = DurationBox.Text;

            try
            {
                string Durat = DurationBox.Text;
                if (int.TryParse(durationText, out int duration))
                {
                    var course = new Course
                    {
                        Name = NameBox.Text,
                        Duration = duration,
                        DepartmentId = (int)DepartmentBox.SelectedValue,
                        InstructorId = (int)InstructorBox.SelectedValue,
                    };

                    db.Courses.Add(course);
                    db.SaveChanges();
                    MessageBox.Show("added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Duration Need to be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update()
        {
            try
            {
                string durationText = DurationBox.Text;

                var course = db.Courses.Find(int.Parse(CoursesBox.SelectedValue.ToString()));

                if (int.TryParse(durationText, out int duration))
                {
                    course.Name = NameBox.Text;
                    course.Duration = duration;
                    course.DepartmentId = (int)DepartmentBox.SelectedValue;
                    course.InstructorId = (int)InstructorBox.SelectedValue;


                    db.SaveChanges();
                    LoadCoursesComboBox();

                    MessageBox.Show("added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Duration Need to be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete()
        {
            try
            {
                int courseId = (int)CoursesBox.SelectedValue;
                var course = db.Courses.Find(courseId);
                db.Courses.Remove(course);
                db.SaveChanges();
                LoadCoursesComboBox();

                MessageBox.Show("deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Cannot delete: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
