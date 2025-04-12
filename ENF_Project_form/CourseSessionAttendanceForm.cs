using System.Data;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;

namespace ENF_Project_form
{
    public partial class CourseSessionAttendanceForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();
        public CourseSessionAttendanceForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            LoadStudentsComboBox();
            LoadCSComboBox();
            if (operation == "update" || operation == "delete")
            {
                CSABox.Enabled = true;
                LoadCSAComboBox();
                fillData();

            }
            if (operation == "delete")
            {
                disapleForm();
            }
        }

        private void disapleForm()
        {
            GradeBox.Enabled = false;
            NotesBox.Enabled = false;
            StudentBox.Enabled = false;
            CSBox.Enabled = false;
        }

        private void LoadCSAComboBox()
        {
            var context = new MyContext();
            var courses = context.CourseSessionAttendances
                .Include(a => a.CourseSession)
                .Include(a => a.Student)
                .Select(a => new
                {
                    AttendanceId = a.Id,
                    SessionTitle = a.CourseSession.Title,
                    StudentName = a.Student.FirstName + " " + a.Student.LastName
                })
                .ToList();

            CSABox.DataSource = courses;
            CSABox.DisplayMember = "SessionTitleAndStudent";
            CSABox.ValueMember = "AttendanceId";
            CSABox.Format += (sender, e) => {
                e.Value = $"{((dynamic)e.ListItem).SessionTitle} - {((dynamic)e.ListItem).StudentName}";
            };

            CSABox.Refresh();

        }
        private void LoadStudentsComboBox()
        {
            var context = new MyContext();
            var students = context.Students.Select(i => new { i.Id, FullName = $"{i.FirstName} {i.LastName}" }).ToList();
            StudentBox.DataSource = students;
            StudentBox.DisplayMember = "FullName";
            StudentBox.ValueMember = "Id";
            StudentBox.Refresh();
        }
        private void LoadCSComboBox()
        {
            var context2 = new MyContext();
            var CS = context2.CourseSessions.Select(i => new { i.Id, i.Title }).ToList();
            CSBox.DataSource = CS;
            CSBox.DisplayMember = "Title";
            CSBox.ValueMember = "Id";
            CSBox.Refresh();
        }
        private void fillData()
        {
            if (CSABox.SelectedValue == null) return;

            int courseId = (int)CSABox.SelectedValue;
            var CSA = db.CourseSessionAttendances.Find(courseId);

            var student = db.Students.Find(CSA.StudentId);
            var CS = db.CourseSessions.Find(CSA.CourseSessionId);

            if (student != null)
            {
                StudentBox.Text = $"{student.FirstName} {student.LastName}";
            }

            if (CS != null)
            {
                CSBox.Text = CS.Title;
            }

            GradeBox.Text = CSA.Grade.ToString();
            NotesBox.Text = CSA.Notes;
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
            string durationText = NotesBox.Text;

            try
            {
                
                string _Grade = GradeBox.Text;
                if (int.TryParse(_Grade, out int Grade))
                {
                    var CSA = new CourseSessionAttendance
                    {
                        Grade = Grade,
                        Notes = NotesBox.Text,
                        StudentId = (int)StudentBox.SelectedValue,
                        CourseSessionId = (int)CSBox.SelectedValue,
                    };

                    db.CourseSessionAttendances.Add(CSA);
                    db.SaveChanges();
                    MessageBox.Show("added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Grade Need to be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string GradeText = GradeBox.Text;

                var CSA = db.CourseSessionAttendances.Find(int.Parse(CSABox.SelectedValue.ToString()));

                CSA.Notes = NotesBox.Text;
                if (int.TryParse(GradeText, out int Grade))
                {
                    CSA.Grade = Grade;
                    CSA.StudentId = (int)StudentBox.SelectedValue;
                    CSA.CourseSessionId = (int)CSBox.SelectedValue;


                    db.SaveChanges();
                    LoadCSAComboBox();

                    MessageBox.Show("updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Grade Need to be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int courseId = (int)CSABox.SelectedValue;
                var CSA = db.CourseSessionAttendances.Find(courseId);
                db.CourseSessionAttendances.Remove(CSA);
                db.SaveChanges();
                LoadCSAComboBox();

                MessageBox.Show("deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Cannot delete: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CourseSessionAttendanceForm_Load(object sender, EventArgs e)
        {

        }


    }
}
