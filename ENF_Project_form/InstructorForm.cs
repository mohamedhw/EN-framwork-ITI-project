using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;

namespace ENF_Project_form
{
    public partial class InstructorForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();
        public InstructorForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            LoadDepartmentsComboBox();
            if (operation == "update" || operation == "delete")
            {
                InstructorsBox.Enabled = true;
                LoadInstructorsComboBox();
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
            DepartmentBox.Enabled = false;
        }


        private void LoadInstructorsComboBox()
        {
            var context = new MyContext();
            var instructors = context.Instructors
            .OrderBy(i => i.LastName)
            .Select(i => new
            {
                i.Id,
                FullName = i.FirstName + " " + i.LastName
            })
            .ToList();

            InstructorsBox.DataSource = instructors;
            InstructorsBox.DisplayMember = "FullName";
            InstructorsBox.ValueMember = "Id";
            InstructorsBox.Refresh();

        }
        private void LoadDepartmentsComboBox()
        {
            var context = new MyContext();
            var departments = context.Departments.Select(d => new { d.Id, d.Name }).ToList();
            DepartmentBox.DataSource = departments;
            DepartmentBox.DisplayMember = "Name";
            DepartmentBox.ValueMember = "Id";
            DepartmentBox.Refresh();
        }
        private void fillData()
        {
            if (InstructorsBox.SelectedValue == null) return;
            int instructorId = (int)InstructorsBox.SelectedValue;
            var instructor = db.Instructors.Find(instructorId);
            var dep = db.Departments.Find(instructor.DepartmentId);
            FirstNameBox.Text = instructor.FirstName;
            LastNameBox.Text = instructor.LastName;
            PhoneBox.Text = instructor.Phone;
            DepartmentBox.Text = dep.Name;
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
            if (!IsValidPhone(PhoneBox.Text))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var instructor = new Instructor
                {
                    FirstName = FirstNameBox.Text,
                    LastName = LastNameBox.Text,
                    Phone = PhoneBox.Text,
                    DepartmentId = (int)DepartmentBox.SelectedValue,
                };
                db.Instructors.Add(instructor);
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
                var instructor = db.Instructors.Find(int.Parse(InstructorsBox.SelectedValue.ToString()));

                instructor.FirstName = FirstNameBox.Text;
                instructor.LastName = LastNameBox.Text;
                instructor.Phone = PhoneBox.Text;
                instructor.DepartmentId = (int)DepartmentBox.SelectedValue;

                db.SaveChanges();
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
                int instructorId = (int)InstructorsBox.SelectedValue;
                var instructor = db.Instructors.Find(instructorId);
                bool isManager = db.Departments.Any(d => d.ManagerId == instructorId);
                bool hasCourses = db.Courses.Any(c => c.InstructorId == instructorId);
                bool hasSessions = db.CourseSessions.Any(cs => cs.InstructorId == instructorId);

                if (isManager || hasCourses || hasSessions)
                {
                    MessageBox.Show("Cannot delete: Instructor has active dependencies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.Instructors.Remove(instructor);
                db.SaveChanges();
                LoadInstructorsComboBox();


                MessageBox.Show("deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Cannot delete: {ex.InnerException?.Message}");
            }
        }
        private bool IsValidPhone(string phone)
        {
            string pattern = @"^\+?[0-9]{10,15}$";
            return Regex.IsMatch(phone, pattern);
        }
        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
