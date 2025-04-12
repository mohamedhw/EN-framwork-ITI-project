using System.Data;
using System.Text.RegularExpressions;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;

namespace ENF_Project_form
{
    public partial class StudentForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();

        public StudentForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            if (operation == "update" || operation == "delete")
            {
                studentsBox.Enabled = true;
                LoadStudentsComboBox();
                fillData();
            }
            if (operation == "delete")
            {
                disapleForm();
            }
        }

        private void disapleForm() 
        {
            FirstNameBox.Enabled = false;
            LastNameBox.Enabled = false;
            PhoneBox.Enabled = false;
        }

        private void LoadStudentsComboBox()
        {
            var context = new MyContext();
            var students = context.Students
            .OrderBy(s => s.LastName)
            .Select(s => new {
                s.Id,
                FullName = s.FirstName + " " + s.LastName
            })
            .ToList();

            studentsBox.DataSource = students;
            studentsBox.DisplayMember = "FullName";
            studentsBox.ValueMember = "Id";
            studentsBox.Refresh();

        }
        private void fillData() {
            if (studentsBox.SelectedValue == null) return;
            int studentId = (int)studentsBox.SelectedValue;
            var student = db.Students.Find(studentId);
            FirstNameBox.Text = student.FirstName;
            LastNameBox.Text = student.LastName;
            PhoneBox.Text = student.Phone;
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            if (!IsValidPhone(PhoneBox.Text))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var student = new Student
                {
                    FirstName = FirstNameBox.Text,
                    LastName = LastNameBox.Text,
                    Phone = PhoneBox.Text
                };
                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update()
        {
            if (!IsValidPhone(PhoneBox.Text))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var student = db.Students.Find(int.Parse(studentsBox.SelectedValue.ToString()));

                student.FirstName = FirstNameBox.Text;
                student.LastName = LastNameBox.Text;
                student.Phone = PhoneBox.Text;

                db.SaveChanges();
                LoadStudentsComboBox();
                MessageBox.Show("updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int studentId = (int)studentsBox.SelectedValue;
                var student = db.Students.Find(studentId);
                db.Students.Remove(student);
                db.SaveChanges();
                LoadStudentsComboBox();


                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Cannot delete: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidPhone(string phone)
        {
            string pattern = @"^\+?[0-9]{10,15}$";
            return Regex.IsMatch(phone, pattern);
        }

    }
}
