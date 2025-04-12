using System.Data;
using ENF_Project_form.Context;
using ENF_Project_form.Models;
using Microsoft.EntityFrameworkCore;

namespace ENF_Project_form
{
    public partial class DepartmentForm : Form
    {
        private string _operation;
        private MyContext db = new MyContext();
        public DepartmentForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            LoadManagersComboBox();
            if (operation == "update" || operation == "delete")
            {
                DepartmentBox.Enabled = true;
                LoadDepartmentComboBox();
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
            LocationBox.Enabled = false;
            ManagerBox.Enabled = false;
        }

        private void LoadDepartmentComboBox()
        {
            var context = new MyContext();
            var departments = context.Departments
            .OrderBy(i => i.Name)
            .Select(i => new
            {
                i.Id,
                i.Name
            })
            .ToList();

            DepartmentBox.DataSource = departments;
            DepartmentBox.DisplayMember = "Name";
            DepartmentBox.ValueMember = "Id";
            DepartmentBox.Refresh();
            int departmentId = (int)DepartmentBox.SelectedValue;
            LoadManagersComboBox(departmentId);
        }
        private void LoadManagersComboBox(int? currentManagerId = null)
        {
            var instractors = db.Instructors.Where(i => i.ManagedDepartment == null || (currentManagerId.HasValue && i.ManagedDepartment.Id == currentManagerId))
                .Select(i => new { i.Id, FullName = $"{i.FirstName} {i.LastName}" }).ToList();

            ManagerBox.DataSource = instractors;
            ManagerBox.DisplayMember = "FullName";
            ManagerBox.ValueMember = "Id";

            ManagerBox.Refresh();
        }
        private void fillData()
        {
            if (DepartmentBox.SelectedValue == null) return;

            int departmentId = (int)DepartmentBox.SelectedValue;

            var department = db.Departments.Find(departmentId);
            var manager = db.Instructors.Find(department.Manager);
            if (manager != null) ManagerBox.Text = $"{manager.FirstName} {manager.LastName}";
            NameBox.Text = department.Name;
            LocationBox.Text = department.Location;
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = (int)DepartmentBox.SelectedValue;
            LoadManagersComboBox(departmentId);
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
            try
            {
                var department = new Department
                {
                    Name = NameBox.Text,
                    Location = LocationBox.Text,
                    ManagerId = (int)ManagerBox.SelectedValue,
                };
                db.Departments.Add(department);
                db.SaveChanges();
                LoadManagersComboBox();
                MessageBox.Show("Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var department = db.Departments.Find(int.Parse(DepartmentBox.SelectedValue.ToString()));

                department.Name = NameBox.Text;
                department.Location = LocationBox.Text;
                department.ManagerId = (int)ManagerBox.SelectedValue;

                db.SaveChanges();
                LoadDepartmentComboBox();

                MessageBox.Show("Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int departmentId = (int)DepartmentBox.SelectedValue;
                var department = db.Departments.Find(departmentId);
                //bool hasCourses = db.Courses.Any(c => c.DepartmentId == departmentId);

                //if (hasInstances || hasCourses)
                //{
                //    MessageBox.Show("Cannot delete department. It has linked instances or courses.");
                //    return;
                //}

                db.Departments.Remove(department);
                db.SaveChanges();
                LoadDepartmentComboBox();


                MessageBox.Show("deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Cannot delete: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
