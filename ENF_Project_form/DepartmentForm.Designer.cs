namespace ENF_Project_form
{
    partial class DepartmentForm
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
            ManagerBox = new ComboBox();
            label1 = new Label();
            DepartmentBox = new ComboBox();
            Submit = new Button();
            Phone = new Label();
            LocationBox = new TextBox();
            Location = new Label();
            NameBox = new TextBox();
            Name = new Label();
            SuspendLayout();
            // 
            // ManagerBox
            // 
            ManagerBox.FormattingEnabled = true;
            ManagerBox.Location = new Point(119, 180);
            ManagerBox.Name = "ManagerBox";
            ManagerBox.Size = new Size(218, 28);
            ManagerBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 180);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 26;
            label1.Text = "Manager";
            // 
            // DepartmentBox
            // 
            DepartmentBox.Enabled = false;
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(558, 57);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(218, 28);
            DepartmentBox.TabIndex = 25;
            DepartmentBox.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(119, 301);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 56);
            Submit.TabIndex = 24;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(24, 188);
            Phone.Name = "Phone";
            Phone.Size = new Size(0, 20);
            Phone.TabIndex = 22;
            // 
            // LocationBox
            // 
            LocationBox.Location = new Point(119, 118);
            LocationBox.Name = "LocationBox";
            LocationBox.Size = new Size(203, 27);
            LocationBox.TabIndex = 21;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(24, 118);
            Location.Name = "Location";
            Location.Size = new Size(66, 20);
            Location.TabIndex = 20;
            Location.Text = "Location";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(119, 57);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(203, 27);
            NameBox.TabIndex = 19;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(24, 60);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 18;
            Name.Text = "Name";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ManagerBox);
            Controls.Add(label1);
            Controls.Add(DepartmentBox);
            Controls.Add(Submit);
            Controls.Add(Phone);
            Controls.Add(LocationBox);
            Controls.Add(Location);
            Controls.Add(NameBox);
            Controls.Add(Name);
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ManagerBox;
        private Label label1;
        private ComboBox DepartmentBox;
        private Button Submit;
        private Label Phone;
        private TextBox LocationBox;
        private Label Location;
        private TextBox NameBox;
        private Label Name;
    }
}