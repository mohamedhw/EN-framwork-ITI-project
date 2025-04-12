namespace ENF_Project_form
{
    partial class StudentCourseForm
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
            Submit = new Button();
            LastName = new Label();
            SelectBox = new ListBox();
            studentsBox = new ComboBox();
            coursesBox = new ComboBox();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Enabled = false;
            Submit.Location = new Point(150, 346);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 14;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(150, 72);
            LastName.Name = "LastName";
            LastName.Size = new Size(54, 20);
            LastName.TabIndex = 10;
            LastName.Text = "Course";
            // 
            // SelectBox
            // 
            SelectBox.Enabled = false;
            SelectBox.FormattingEnabled = true;
            SelectBox.Location = new Point(150, 103);
            SelectBox.Name = "SelectBox";
            SelectBox.Size = new Size(234, 184);
            SelectBox.TabIndex = 19;
            // 
            // studentsBox
            // 
            studentsBox.FormattingEnabled = true;
            studentsBox.Location = new Point(496, 103);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(234, 28);
            studentsBox.TabIndex = 20;
            // 
            // coursesBox
            // 
            coursesBox.FormattingEnabled = true;
            coursesBox.Location = new Point(496, 171);
            coursesBox.Name = "coursesBox";
            coursesBox.Size = new Size(234, 28);
            coursesBox.TabIndex = 21;
            // 
            // StudentCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coursesBox);
            Controls.Add(studentsBox);
            Controls.Add(SelectBox);
            Controls.Add(Submit);
            Controls.Add(LastName);
            Name = "StudentCourseForm";
            Text = "StudentCourseForm";
            Load += StudentCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox studentCourseBox;
        private Button Submit;
        private Label LastName;
        private ListBox listBox1;
        private ListBox SelectBox;
        private ComboBox studentsBox;
        private ComboBox coursesBox;
    }
}