using System.Data;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;

namespace ENF_Project_form
{
    public partial class CourseSessionForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();
        public CourseSessionForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            LoadCourseComboBox();
            LoadDepartmentComboBox();
            if (operation == "update" || operation == "delete")
            {
                CSBox.Enabled = true;
                LoadCSComboBox();
                fillData();

            }
            if (operation == "delete")
            {
                disapleForm();
            }
        }
        private void disapleForm()
        {
            TitleBox.Enabled = false;
            DateBox.Enabled = false;
            CourseBox.Enabled = false;
            InstructorBox.Enabled = false;
        }

        private void LoadCSComboBox()
        {
            var context = new MyContext();
            var coursesSession = context.CourseSessions
            .OrderBy(i => i.Title)
            .Select(i => new {
                i.Id,
                i.Title
            })
            .ToList();

            CSBox.DataSource = coursesSession;
            CSBox.DisplayMember = "Title";
            CSBox.ValueMember = "Id";
            CSBox.Refresh();

        }

        private void LoadDepartmentComboBox()
        {
            var context = new MyContext();
            var departments = context.Departments.Select(i => new { i.Id, i.Name }).ToList();
            CourseBox.DataSource = departments;
            CourseBox.DisplayMember = "Name";
            CourseBox.ValueMember = "Id";
            CourseBox.Refresh();
        }
        private void LoadCourseComboBox()
        {
            var context2 = new MyContext();
            var instractors = db.Instructors.Select(i => new { i.Id, FullName = $"{i.FirstName} {i.LastName}" }).ToList();
            InstructorBox.DataSource = instractors;
            InstructorBox.DisplayMember = "FullName";
            InstructorBox.ValueMember = "Id";
            InstructorBox.Refresh();
        }

        private void fillData()
        {
            if (CSBox.SelectedValue == null) return;

            int CSId = (int)CSBox.SelectedValue;
            var CS = db.CourseSessions.Find(CSId);

            var course = db.Departments.Find(CS.CourseId);
            var instructor = db.Instructors.Find(CS.InstructorId);

            if (course != null)
            {
                CourseBox.Text = course.Name;
            }
            if (instructor != null)
            {
                InstructorBox.Text = $"{instructor.FirstName} {instructor.LastName}";
            }
            TitleBox.Text = CS.Title;
            DateBox.Text = CS.Date.ToString();
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
            string durationText = DateBox.Text;

            try
            {
                if (!DateTime.TryParse(DateBox.Text, out DateTime sessionDate))
                {
                    MessageBox.Show("Invalid date format! Please use yyyy-mm-dd format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Durat = DateBox.Text;

                    var SC = new CourseSession
                    {
                        Title = TitleBox.Text,
                        Date = sessionDate,
                        CourseId = (int)CourseBox.SelectedValue,
                        InstructorId = (int)InstructorBox.SelectedValue,
                    };

                    db.CourseSessions.Add(SC);
                    db.SaveChanges();
                    MessageBox.Show("added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
                if (!DateTime.TryParse(DateBox.Text, out DateTime sessionDate))
                {
                    MessageBox.Show("Invalid date format! Please use yyyy-mm-dd format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var course = db.CourseSessions.Find(int.Parse(CSBox.SelectedValue.ToString()));

                course.Title = TitleBox.Text;
                course.Date = sessionDate;
                course.CourseId = (int)CourseBox.SelectedValue;
                course.InstructorId = (int)InstructorBox.SelectedValue;


                db.SaveChanges();
                LoadCSComboBox();

                MessageBox.Show("added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int courseId = (int)CSBox.SelectedValue;
                var course = db.CourseSessions.Find(courseId);
                db.CourseSessions.Remove(course);
                db.SaveChanges();
                LoadCSComboBox();

                MessageBox.Show("deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Cannot delete: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CourseSessionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
