namespace kursach.Pages
{
    partial class Journal
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
            this.ReoGrid = new unvell.ReoGrid.ReoGridControl();
            this.ComboBoxMonth = new System.Windows.Forms.ComboBox();
            this.ComboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReoGrid
            // 
            this.ReoGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReoGrid.ColumnHeaderContextMenuStrip = null;
            this.ReoGrid.LeadHeaderContextMenuStrip = null;
            this.ReoGrid.Location = new System.Drawing.Point(12, 41);
            this.ReoGrid.Name = "ReoGrid";
            this.ReoGrid.RowHeaderContextMenuStrip = null;
            this.ReoGrid.Script = null;
            this.ReoGrid.SheetTabContextMenuStrip = null;
            this.ReoGrid.SheetTabNewButtonVisible = true;
            this.ReoGrid.SheetTabVisible = true;
            this.ReoGrid.SheetTabWidth = 60;
            this.ReoGrid.ShowScrollEndSpacing = true;
            this.ReoGrid.Size = new System.Drawing.Size(1189, 542);
            this.ReoGrid.TabIndex = 0;
            this.ReoGrid.Text = "reoGridControl1";
            this.ReoGrid.TextChanged += new System.EventHandler(this.ReoGrid_TextChanged);
            // 
            // ComboBoxMonth
            // 
            this.ComboBoxMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxMonth.FormattingEnabled = true;
            this.ComboBoxMonth.Location = new System.Drawing.Point(75, 6);
            this.ComboBoxMonth.Name = "ComboBoxMonth";
            this.ComboBoxMonth.Size = new System.Drawing.Size(159, 29);
            this.ComboBoxMonth.TabIndex = 1;
            this.ComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMonth_SelectedIndexChanged);
            // 
            // ComboBoxGroup
            // 
            this.ComboBoxGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.Location = new System.Drawing.Point(307, 6);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new System.Drawing.Size(163, 29);
            this.ComboBoxGroup.TabIndex = 2;
            this.ComboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Месяц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группа";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(476, 6);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(119, 29);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxGroup);
            this.Controls.Add(this.ComboBoxMonth);
            this.Controls.Add(this.ReoGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Journal";
            this.Text = "Journal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private unvell.ReoGrid.ReoGridControl ReoGrid;
        private System.Windows.Forms.ComboBox ComboBoxMonth;
        private System.Windows.Forms.ComboBox ComboBoxGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSave;
    }
}