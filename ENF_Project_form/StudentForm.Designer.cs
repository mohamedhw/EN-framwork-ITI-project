namespace ENF_Project_form
{
    partial class StudentForm
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
            FirstName = new Label();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            LastName = new Label();
            PhoneBox = new TextBox();
            Phone = new Label();
            Submit = new Button();
            studentsBox = new ComboBox();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(12, 93);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(80, 20);
            FirstName.TabIndex = 0;
            FirstName.Text = "First Name";
            FirstName.Click += label1_Click;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(107, 90);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(203, 27);
            FirstNameBox.TabIndex = 1;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(107, 151);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(203, 27);
            LastNameBox.TabIndex = 3;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(12, 151);
            LastName.Name = "LastName";
            LastName.Size = new Size(79, 20);
            LastName.TabIndex = 2;
            LastName.Text = "Last Name";
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(107, 221);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(203, 27);
            PhoneBox.TabIndex = 5;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(12, 221);
            Phone.Name = "Phone";
            Phone.Size = new Size(50, 20);
            Phone.TabIndex = 4;
            Phone.Text = "Phone";
            // 
            // Submit
            // 
            Submit.Location = new Point(133, 333);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 6;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += button1_Click;
            // 
            // studentsBox
            // 
            studentsBox.Enabled = false;
            studentsBox.FormattingEnabled = true;
            studentsBox.Location = new Point(546, 90);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(218, 28);
            studentsBox.TabIndex = 7;
            studentsBox.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentsBox);
            Controls.Add(Submit);
            Controls.Add(PhoneBox);
            Controls.Add(Phone);
            Controls.Add(LastNameBox);
            Controls.Add(LastName);
            Controls.Add(FirstNameBox);
            Controls.Add(FirstName);
            Name = "StudentForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private Label LastName;
        private TextBox PhoneBox;
        private Label Phone;
        private Button Submit;
        private ComboBox studentsBox;
    }
}