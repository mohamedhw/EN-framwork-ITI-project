namespace ENF_Project_form
{
    partial class CourseSessionAttendanceForm
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
            CSBox = new ComboBox();
            label2 = new Label();
            StudentBox = new ComboBox();
            label1 = new Label();
            CSABox = new ComboBox();
            Submit = new Button();
            NotesBox = new TextBox();
            Location = new Label();
            GradeBox = new TextBox();
            Name = new Label();
            SuspendLayout();
            // 
            // CSBox
            // 
            CSBox.FormattingEnabled = true;
            CSBox.Location = new Point(146, 259);
            CSBox.Name = "CSBox";
            CSBox.Size = new Size(218, 28);
            CSBox.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 259);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 46;
            label2.Text = "Course Session";
            // 
            // StudentBox
            // 
            StudentBox.FormattingEnabled = true;
            StudentBox.Location = new Point(146, 198);
            StudentBox.Name = "StudentBox";
            StudentBox.Size = new Size(218, 28);
            StudentBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 198);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 44;
            label1.Text = "Student";
            // 
            // CSABox
            // 
            CSABox.Enabled = false;
            CSABox.FormattingEnabled = true;
            CSABox.Location = new Point(462, 75);
            CSABox.Name = "CSABox";
            CSABox.Size = new Size(314, 28);
            CSABox.TabIndex = 43;
            CSABox.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(146, 331);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 42;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // NotesBox
            // 
            NotesBox.Location = new Point(146, 136);
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(218, 27);
            NotesBox.TabIndex = 41;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(24, 136);
            Location.Name = "Location";
            Location.Size = new Size(48, 20);
            Location.TabIndex = 40;
            Location.Text = "Notes";
            // 
            // GradeBox
            // 
            GradeBox.Location = new Point(146, 75);
            GradeBox.Name = "GradeBox";
            GradeBox.Size = new Size(218, 27);
            GradeBox.TabIndex = 39;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(24, 78);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 38;
            Name.Text = "Grade";
            // 
            // CourseSessionAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CSBox);
            Controls.Add(label2);
            Controls.Add(StudentBox);
            Controls.Add(label1);
            Controls.Add(CSABox);
            Controls.Add(Submit);
            Controls.Add(NotesBox);
            Controls.Add(Location);
            Controls.Add(GradeBox);
            Controls.Add(Name);
            Text = "CourseSessionAttendanceForm";
            Load += CourseSessionAttendanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CSBox;
        private Label label2;
        private ComboBox StudentBox;
        private Label label1;
        private ComboBox CSABox;
        private Button Submit;
        private TextBox NotesBox;
        private Label Location;
        private TextBox GradeBox;
        private Label Name;
    }
}