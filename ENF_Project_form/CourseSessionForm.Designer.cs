namespace ENF_Project_form
{
    partial class CourseSessionForm
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
            InstructorBox = new ComboBox();
            label2 = new Label();
            CourseBox = new ComboBox();
            label1 = new Label();
            CSBox = new ComboBox();
            Submit = new Button();
            Location = new Label();
            TitleBox = new TextBox();
            Name = new Label();
            DateBox = new DateTimePicker();
            SuspendLayout();
            // 
            // InstructorBox
            // 
            InstructorBox.FormattingEnabled = true;
            InstructorBox.Location = new Point(119, 189);
            InstructorBox.Name = "InstructorBox";
            InstructorBox.Size = new Size(218, 28);
            InstructorBox.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 189);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 46;
            label2.Text = "Instructor";
            // 
            // CourseBox
            // 
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(119, 128);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(218, 28);
            CourseBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 128);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 44;
            label1.Text = "Course";
            // 
            // CSBox
            // 
            CSBox.Enabled = false;
            CSBox.FormattingEnabled = true;
            CSBox.Location = new Point(558, 75);
            CSBox.Name = "CSBox";
            CSBox.Size = new Size(218, 28);
            CSBox.TabIndex = 43;
            CSBox.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(119, 352);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 42;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(24, 243);
            Location.Name = "Location";
            Location.Size = new Size(41, 20);
            Location.TabIndex = 40;
            Location.Text = "Date";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(119, 71);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(218, 27);
            TitleBox.TabIndex = 39;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(24, 78);
            Name.Name = "Name";
            Name.Size = new Size(38, 20);
            Name.TabIndex = 38;
            Name.Text = "Title";
            // 
            // DateBox
            // 
            DateBox.Location = new Point(119, 243);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(250, 27);
            DateBox.TabIndex = 49;
            // 
            // CourseSessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DateBox);
            Controls.Add(InstructorBox);
            Controls.Add(label2);
            Controls.Add(CourseBox);
            Controls.Add(label1);
            Controls.Add(CSBox);
            Controls.Add(Submit);
            Controls.Add(Location);
            Controls.Add(TitleBox);
            Controls.Add(Name);
            Text = "CourseSessionForm";
            Load += CourseSessionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox InstructorBox;
        private Label label2;
        private ComboBox CourseBox;
        private Label label1;
        private ComboBox CSBox;
        private Button Submit;
        private Label Location;
        private TextBox TitleBox;
        private Label Name;
        private DateTimePicker DateBox;
    }
}