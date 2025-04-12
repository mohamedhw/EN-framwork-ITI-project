namespace ENF_Project_form
{
    partial class InstructorForm
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
            InstructorsBox = new ComboBox();
            Submit = new Button();
            PhoneBox = new TextBox();
            Phone = new Label();
            LastNameBox = new TextBox();
            LastName = new Label();
            FirstNameBox = new TextBox();
            FirstName = new Label();
            label1 = new Label();
            DepartmentBox = new ComboBox();
            SuspendLayout();
            // 
            // InstructorsBox
            // 
            InstructorsBox.Enabled = false;
            InstructorsBox.FormattingEnabled = true;
            InstructorsBox.Location = new Point(558, 76);
            InstructorsBox.Name = "InstructorsBox";
            InstructorsBox.Size = new Size(218, 28);
            InstructorsBox.TabIndex = 15;
            InstructorsBox.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(119, 357);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 14;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(119, 207);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(203, 27);
            PhoneBox.TabIndex = 13;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(24, 207);
            Phone.Name = "Phone";
            Phone.Size = new Size(50, 20);
            Phone.TabIndex = 12;
            Phone.Text = "Phone";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(119, 137);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(203, 27);
            LastNameBox.TabIndex = 11;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(24, 137);
            LastName.Name = "LastName";
            LastName.Size = new Size(79, 20);
            LastName.TabIndex = 10;
            LastName.Text = "Last Name";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(119, 76);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(203, 27);
            FirstNameBox.TabIndex = 9;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(24, 79);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(80, 20);
            FirstName.TabIndex = 8;
            FirstName.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 268);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 16;
            label1.Text = "Department";
            // 
            // DepartmentBox
            // 
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(119, 268);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(218, 28);
            DepartmentBox.TabIndex = 17;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DepartmentBox);
            Controls.Add(label1);
            Controls.Add(InstructorsBox);
            Controls.Add(Submit);
            Controls.Add(PhoneBox);
            Controls.Add(Phone);
            Controls.Add(LastNameBox);
            Controls.Add(LastName);
            Controls.Add(FirstNameBox);
            Controls.Add(FirstName);
            Name = "InstructorForm";
            Text = "InstructorForm";
            Load += InstructorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox InstructorsBox;
        private Button Submit;
        private TextBox PhoneBox;
        private Label Phone;
        private TextBox LastNameBox;
        private Label LastName;
        private TextBox FirstNameBox;
        private Label FirstName;
        private Label label1;
        private ComboBox DepartmentBox;
    }
}