namespace ENF_Project_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip2 = new MenuStrip();
            Tables = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            courseToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            instractorsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem1 = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            instructorsToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            instructorToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            addToolStripMenuItem2 = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            courseToolStripMenuItem1 = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem3 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            courseSessionToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem1 = new ToolStripMenuItem();
            addToolStripMenuItem4 = new ToolStripMenuItem();
            updateToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem3 = new ToolStripMenuItem();
            courseSessionAttendanceToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem2 = new ToolStripMenuItem();
            addToolStripMenuItem5 = new ToolStripMenuItem();
            updateToolStripMenuItem3 = new ToolStripMenuItem();
            deleteToolStripMenuItem4 = new ToolStripMenuItem();
            studentCourseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem6 = new ToolStripMenuItem();
            addToolStripMenuItem7 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ButtonFace;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { Tables, addToolStripMenuItem, instructorToolStripMenuItem, courseToolStripMenuItem1, courseSessionToolStripMenuItem, courseSessionAttendanceToolStripMenuItem, studentCourseToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1172, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // Tables
            // 
            Tables.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem, courseToolStripMenuItem, departmentToolStripMenuItem, instractorsToolStripMenuItem });
            Tables.Name = "Tables";
            Tables.Size = new Size(74, 24);
            Tables.Text = "Student";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(141, 26);
            studentToolStripMenuItem.Text = "Select";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(141, 26);
            courseToolStripMenuItem.Text = "Add";
            courseToolStripMenuItem.Click += courseToolStripMenuItem_Click;
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(141, 26);
            departmentToolStripMenuItem.Text = "Update";
            departmentToolStripMenuItem.Click += departmentToolStripMenuItem_Click;
            // 
            // instractorsToolStripMenuItem
            // 
            instractorsToolStripMenuItem.Name = "instractorsToolStripMenuItem";
            instractorsToolStripMenuItem.Size = new Size(141, 26);
            instractorsToolStripMenuItem.Text = "Delete";
            instractorsToolStripMenuItem.Click += instractorsToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentsToolStripMenuItem1, departmentsToolStripMenuItem, instructorsToolStripMenuItem, deleteToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(103, 24);
            addToolStripMenuItem.Text = "Department";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem1
            // 
            studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            studentsToolStripMenuItem1.Size = new Size(141, 26);
            studentsToolStripMenuItem1.Text = "Select";
            studentsToolStripMenuItem1.Click += studentsToolStripMenuItem1_Click;
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(141, 26);
            departmentsToolStripMenuItem.Text = "Add";
            departmentsToolStripMenuItem.Click += departmentsToolStripMenuItem_Click;
            // 
            // instructorsToolStripMenuItem
            // 
            instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            instructorsToolStripMenuItem.Size = new Size(141, 26);
            instructorsToolStripMenuItem.Text = "Update";
            instructorsToolStripMenuItem.Click += instructorsToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // instructorToolStripMenuItem
            // 
            instructorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, addToolStripMenuItem2, updateToolStripMenuItem, deleteToolStripMenuItem1 });
            instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            instructorToolStripMenuItem.Size = new Size(85, 24);
            instructorToolStripMenuItem.Text = "Instructor";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(141, 26);
            addToolStripMenuItem1.Text = "Select";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // addToolStripMenuItem2
            // 
            addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            addToolStripMenuItem2.Size = new Size(141, 26);
            addToolStripMenuItem2.Text = "Add";
            addToolStripMenuItem2.Click += addToolStripMenuItem2_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(141, 26);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(141, 26);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // courseToolStripMenuItem1
            // 
            courseToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem, addToolStripMenuItem3, updateToolStripMenuItem1, deleteToolStripMenuItem2 });
            courseToolStripMenuItem1.Name = "courseToolStripMenuItem1";
            courseToolStripMenuItem1.Size = new Size(68, 24);
            courseToolStripMenuItem1.Text = "Course";
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(141, 26);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem3
            // 
            addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            addToolStripMenuItem3.Size = new Size(141, 26);
            addToolStripMenuItem3.Text = "Add";
            addToolStripMenuItem3.Click += addToolStripMenuItem3_Click;
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(141, 26);
            updateToolStripMenuItem1.Text = "Update";
            updateToolStripMenuItem1.Click += updateToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(141, 26);
            deleteToolStripMenuItem2.Text = "Delete";
            deleteToolStripMenuItem2.Click += deleteToolStripMenuItem2_Click;
            // 
            // courseSessionToolStripMenuItem
            // 
            courseSessionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem1, addToolStripMenuItem4, updateToolStripMenuItem2, deleteToolStripMenuItem3 });
            courseSessionToolStripMenuItem.Name = "courseSessionToolStripMenuItem";
            courseSessionToolStripMenuItem.Size = new Size(117, 24);
            courseSessionToolStripMenuItem.Text = "CourseSession";
            // 
            // selectToolStripMenuItem1
            // 
            selectToolStripMenuItem1.Name = "selectToolStripMenuItem1";
            selectToolStripMenuItem1.Size = new Size(141, 26);
            selectToolStripMenuItem1.Text = "Select";
            selectToolStripMenuItem1.Click += selectToolStripMenuItem1_Click;
            // 
            // addToolStripMenuItem4
            // 
            addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            addToolStripMenuItem4.Size = new Size(141, 26);
            addToolStripMenuItem4.Text = "Add";
            addToolStripMenuItem4.Click += addToolStripMenuItem4_Click;
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(141, 26);
            updateToolStripMenuItem2.Text = "Update";
            updateToolStripMenuItem2.Click += updateToolStripMenuItem2_Click;
            // 
            // deleteToolStripMenuItem3
            // 
            deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            deleteToolStripMenuItem3.Size = new Size(141, 26);
            deleteToolStripMenuItem3.Text = "Delete";
            deleteToolStripMenuItem3.Click += deleteToolStripMenuItem3_Click;
            // 
            // courseSessionAttendanceToolStripMenuItem
            // 
            courseSessionAttendanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem2, addToolStripMenuItem5, updateToolStripMenuItem3, deleteToolStripMenuItem4 });
            courseSessionAttendanceToolStripMenuItem.Name = "courseSessionAttendanceToolStripMenuItem";
            courseSessionAttendanceToolStripMenuItem.Size = new Size(193, 24);
            courseSessionAttendanceToolStripMenuItem.Text = "CourseSessionAttendance";
            // 
            // selectToolStripMenuItem2
            // 
            selectToolStripMenuItem2.Name = "selectToolStripMenuItem2";
            selectToolStripMenuItem2.Size = new Size(141, 26);
            selectToolStripMenuItem2.Text = "Select";
            selectToolStripMenuItem2.Click += selectToolStripMenuItem2_Click;
            // 
            // addToolStripMenuItem5
            // 
            addToolStripMenuItem5.Name = "addToolStripMenuItem5";
            addToolStripMenuItem5.Size = new Size(141, 26);
            addToolStripMenuItem5.Text = "Add";
            addToolStripMenuItem5.Click += addToolStripMenuItem5_Click;
            // 
            // updateToolStripMenuItem3
            // 
            updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            updateToolStripMenuItem3.Size = new Size(141, 26);
            updateToolStripMenuItem3.Text = "Update";
            updateToolStripMenuItem3.Click += updateToolStripMenuItem3_Click;
            // 
            // deleteToolStripMenuItem4
            // 
            deleteToolStripMenuItem4.Name = "deleteToolStripMenuItem4";
            deleteToolStripMenuItem4.Size = new Size(141, 26);
            deleteToolStripMenuItem4.Text = "Delete";
            deleteToolStripMenuItem4.Click += deleteToolStripMenuItem4_Click;
            // 
            // studentCourseToolStripMenuItem
            // 
            studentCourseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem6, addToolStripMenuItem7 });
            studentCourseToolStripMenuItem.Name = "studentCourseToolStripMenuItem";
            studentCourseToolStripMenuItem.Size = new Size(119, 24);
            studentCourseToolStripMenuItem.Text = "StudentCourse";
            // 
            // addToolStripMenuItem6
            // 
            addToolStripMenuItem6.Name = "addToolStripMenuItem6";
            addToolStripMenuItem6.Size = new Size(132, 26);
            addToolStripMenuItem6.Text = "Select";
            addToolStripMenuItem6.Click += SelectToolStripMenuItem6_Click;
            // 
            // addToolStripMenuItem7
            // 
            addToolStripMenuItem7.Name = "addToolStripMenuItem7";
            addToolStripMenuItem7.Size = new Size(132, 26);
            addToolStripMenuItem7.Text = "other";
            addToolStripMenuItem7.Click += addToolStripMenuItem7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(497, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 380);
            label1.Name = "label1";
            label1.Size = new Size(416, 50);
            label1.TabIndex = 3;
            label1.Text = "Entity and LNQ Project";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1172, 542);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem Tables;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem instractorsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem1;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem instructorsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem instructorToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem courseToolStripMenuItem1;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem3;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripMenuItem courseSessionToolStripMenuItem;
        private ToolStripMenuItem selectToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem4;
        private ToolStripMenuItem updateToolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem3;
        private ToolStripMenuItem courseSessionAttendanceToolStripMenuItem;
        private ToolStripMenuItem selectToolStripMenuItem2;
        private ToolStripMenuItem addToolStripMenuItem5;
        private ToolStripMenuItem updateToolStripMenuItem3;
        private ToolStripMenuItem deleteToolStripMenuItem4;
        private ToolStripMenuItem studentCourseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem6;
        private ToolStripMenuItem addToolStripMenuItem7;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
