namespace ENF_Project_form
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DepartmentBox = new ComboBox();
            label1 = new Label();
            CoursesBox = new ComboBox();
            Submit = new Button();
            DurationBox = new TextBox();
            Location = new Label();
            NameBox = new TextBox();
            Name = new Label();
            InstructorBox = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // DepartmentBox
            // 
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(119, 198);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(218, 28);
            DepartmentBox.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 198);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 34;
            label1.Text = "Department";
            // 
            // CoursesBox
            // 
            CoursesBox.Enabled = false;
            CoursesBox.FormattingEnabled = true;
            CoursesBox.Location = new Point(558, 75);
            CoursesBox.Name = "CoursesBox";
            CoursesBox.Size = new Size(218, 28);
            CoursesBox.TabIndex = 33;
            CoursesBox.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(119, 319);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 32;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // DurationBox
            // 
            DurationBox.Location = new Point(119, 136);
            DurationBox.Name = "DurationBox";
            DurationBox.Size = new Size(203, 27);
            DurationBox.TabIndex = 31;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(24, 136);
            Location.Name = "Location";
            Location.Size = new Size(67, 20);
            Location.TabIndex = 30;
            Location.Text = "Duration";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(119, 75);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(203, 27);
            NameBox.TabIndex = 29;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(24, 78);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 28;
            Name.Text = "Name";
            // 
            // InstructorBox
            // 
            InstructorBox.FormattingEnabled = true;
            InstructorBox.Location = new Point(119, 259);
            InstructorBox.Name = "InstructorBox";
            InstructorBox.Size = new Size(218, 28);
            InstructorBox.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 259);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 36;
            label2.Text = "Instructor";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InstructorBox);
            Controls.Add(label2);
            Controls.Add(DepartmentBox);
            Controls.Add(label1);
            Controls.Add(CoursesBox);
            Controls.Add(Submit);
            Controls.Add(DurationBox);
            Controls.Add(Location);
            Controls.Add(NameBox);
            Controls.Add(Name);
            Text = "CourseForm";
            Load += CourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DepartmentBox;
        private Label label1;
        private ComboBox CoursesBox;
        private Button Submit;
        private TextBox DurationBox;
        private Label Location;
        private TextBox NameBox;
        private Label Name;
        private ComboBox InstructorBox;
        private Label label2;
    }
}