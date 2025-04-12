namespace ENF_Project_form
{
    partial class SelectForm
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
            Table_Data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Table_Data).BeginInit();
            SuspendLayout();
            // 
            // Table_Data
            // 
            Table_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table_Data.Dock = DockStyle.Fill;
            Table_Data.Enabled = false;
            Table_Data.Location = new Point(0, 0);
            Table_Data.Name = "Table_Data";
            Table_Data.RowHeadersWidth = 51;
            Table_Data.Size = new Size(1169, 450);
            Table_Data.TabIndex = 0;
            Table_Data.CellContentClick += Table_Data_CellContentClick;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 450);
            Controls.Add(Table_Data);
            Name = "SelectForm";
            Text = "Select";
            ((System.ComponentModel.ISupportInitialize)Table_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Table_Data;
    }
}