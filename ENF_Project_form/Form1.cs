using System.Windows.Forms;
using ENF_Project_form.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace ENF_Project_form
{
    public partial class Form1 : Form
    {
        private MyContext db = new MyContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowSelectForm(string tableName)
        {
            SelectForm selectForm = new SelectForm(tableName);
            selectForm.Show();
        }

        private void ShowStudentForm(string opration)
        {
            StudentForm studentForm = new StudentForm(opration);
            studentForm.Show();
        }
        private void ShowInstructorForm(string opration)
        {
            InstructorForm instructorForm = new InstructorForm(opration);
            instructorForm.Show();
        }
        private void ShowDepartmentForm(string opration)
        {
            DepartmentForm DepartmentForm = new DepartmentForm(opration);
            DepartmentForm.Show();
        }
        private void ShowCourseForm(string opration)
        {
            CourseForm departmentForm = new CourseForm(opration);
            departmentForm.Show();
        }
        private void ShowCourseSessionForm(string opration)
        {
            CourseSessionForm departmentForm = new CourseSessionForm(opration);
            departmentForm.Show();
        }
        private void ShowCourseSessionAttendanceForm(string opration)
        {
            CourseSessionAttendanceForm departmentForm = new CourseSessionAttendanceForm(opration);
            departmentForm.Show();
        }
        private void ShowStudentCourseForm(string opration)
        {
            StudentCourseForm departmentForm = new StudentCourseForm(opration);
            departmentForm.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSelectForm("student");
        }


        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowSelectForm("department");
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowSelectForm("Instructor");
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSelectForm("course");
        }

        private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowSelectForm("CourseSession");

        }

        private void selectToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowSelectForm("CourseSessionAttendance");
        }

        private void SelectToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ShowSelectForm("StudentCourse");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentForm("add");
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentForm("update");
        }

        private void instractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentForm("delete");
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowInstructorForm("add");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInstructorForm("update");
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowInstructorForm("delete");
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDepartmentForm("add");
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDepartmentForm("update");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDepartmentForm("delete");
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowCourseForm("add");
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowCourseForm("update");
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowCourseForm("delete");
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowCourseSessionForm("add");
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowCourseSessionForm("update");
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowCourseSessionForm("delete");
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ShowCourseSessionAttendanceForm("add");
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowCourseSessionAttendanceForm("update");
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowCourseSessionAttendanceForm("delete");
        }

        private void addToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ShowStudentCourseForm("add");
        }


        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ShowStudentCourseForm("delete");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }







        //private void tabPage1_Click(object sender, EventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void S_data_load(object sender, EventArgs e)
        //{
        //    db.Students.Load();
        //    S_Table.DataSource = db.Students.Local.ToBindingList();
        //}
        //private void Dep_data_load(object sender, EventArgs e)
        //{
        //    db.Departments.Load();
        //    D_Table.DataSource = db.Departments.Local.ToBindingList();
        //}
        //private void Ins_data_load(object sender, EventArgs e)
        //{
        //    db.Instructors.Load();
        //    INS_Table.DataSource = db.Instructors.Local.ToBindingList();
        //}
        //private void Course_data_load(object sender, EventArgs e)
        //{
        //    db.Courses.Load();
        //    C_Table.DataSource = db.Courses.Local.ToBindingList();
        //}
        //private void CS_data_load(object sender, EventArgs e)
        //{
        //    db.CourseSessions.Load();
        //    CS_Table.DataSource = db.CourseSessions.Local.ToBindingList();
        //}
        //private void CSA_data_load(object sender, EventArgs e)
        //{
        //    db.CourseSessionAttendances.Load();
        //    CSA_Table.DataSource = db.CourseSessionAttendances.Local.ToBindingList();
        //}


    }
}
