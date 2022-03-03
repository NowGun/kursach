namespace kursach.Pages
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.ComboBoxSorting = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxStudentsFIO = new System.Windows.Forms.TextBox();
            this.TextBoxStudentsPhone = new System.Windows.Forms.TextBox();
            this.TextBoxStudentsResidence = new System.Windows.Forms.TextBox();
            this.TextBoxParentFIO = new System.Windows.Forms.TextBox();
            this.TextBoxParentPhone = new System.Windows.Forms.TextBox();
            this.ComboBoxGroups = new System.Windows.Forms.ComboBox();
            this.ListBoxGroups = new System.Windows.Forms.ListBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.CheckBoxStudentsDormitory = new System.Windows.Forms.CheckBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxSorting
            // 
            this.ComboBoxSorting.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxSorting.FormattingEnabled = true;
            this.ComboBoxSorting.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.ComboBoxSorting.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxSorting.Name = "ComboBoxSorting";
            this.ComboBoxSorting.Size = new System.Drawing.Size(263, 31);
            this.ComboBoxSorting.TabIndex = 1;
            this.ComboBoxSorting.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSorting_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.Location = new System.Drawing.Point(12, 547);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(120, 35);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.Location = new System.Drawing.Point(148, 548);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(127, 35);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxStudentsFIO
            // 
            this.TextBoxStudentsFIO.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxStudentsFIO.Location = new System.Drawing.Point(396, 67);
            this.TextBoxStudentsFIO.Multiline = true;
            this.TextBoxStudentsFIO.Name = "TextBoxStudentsFIO";
            this.TextBoxStudentsFIO.Size = new System.Drawing.Size(534, 35);
            this.TextBoxStudentsFIO.TabIndex = 4;
            // 
            // TextBoxStudentsPhone
            // 
            this.TextBoxStudentsPhone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxStudentsPhone.Location = new System.Drawing.Point(396, 142);
            this.TextBoxStudentsPhone.Multiline = true;
            this.TextBoxStudentsPhone.Name = "TextBoxStudentsPhone";
            this.TextBoxStudentsPhone.Size = new System.Drawing.Size(171, 35);
            this.TextBoxStudentsPhone.TabIndex = 5;
            // 
            // TextBoxStudentsResidence
            // 
            this.TextBoxStudentsResidence.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxStudentsResidence.Location = new System.Drawing.Point(472, 215);
            this.TextBoxStudentsResidence.Multiline = true;
            this.TextBoxStudentsResidence.Name = "TextBoxStudentsResidence";
            this.TextBoxStudentsResidence.Size = new System.Drawing.Size(449, 35);
            this.TextBoxStudentsResidence.TabIndex = 7;
            // 
            // TextBoxParentFIO
            // 
            this.TextBoxParentFIO.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxParentFIO.Location = new System.Drawing.Point(472, 366);
            this.TextBoxParentFIO.Multiline = true;
            this.TextBoxParentFIO.Name = "TextBoxParentFIO";
            this.TextBoxParentFIO.Size = new System.Drawing.Size(449, 35);
            this.TextBoxParentFIO.TabIndex = 8;
            // 
            // TextBoxParentPhone
            // 
            this.TextBoxParentPhone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxParentPhone.Location = new System.Drawing.Point(472, 423);
            this.TextBoxParentPhone.Multiline = true;
            this.TextBoxParentPhone.Name = "TextBoxParentPhone";
            this.TextBoxParentPhone.Size = new System.Drawing.Size(134, 35);
            this.TextBoxParentPhone.TabIndex = 9;
            // 
            // ComboBoxGroups
            // 
            this.ComboBoxGroups.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxGroups.FormattingEnabled = true;
            this.ComboBoxGroups.Location = new System.Drawing.Point(980, 58);
            this.ComboBoxGroups.Name = "ComboBoxGroups";
            this.ComboBoxGroups.Size = new System.Drawing.Size(221, 31);
            this.ComboBoxGroups.TabIndex = 10;
            this.ComboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroups_SelectedIndexChanged);
            // 
            // ListBoxGroups
            // 
            this.ListBoxGroups.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxGroups.FormattingEnabled = true;
            this.ListBoxGroups.ItemHeight = 23;
            this.ListBoxGroups.Location = new System.Drawing.Point(980, 95);
            this.ListBoxGroups.Name = "ListBoxGroups";
            this.ListBoxGroups.Size = new System.Drawing.Size(221, 395);
            this.ListBoxGroups.TabIndex = 11;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(1055, 547);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(146, 35);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxStudents);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 483);
            this.panel1.TabIndex = 13;
            // 
            // ListBoxStudents
            // 
            this.ListBoxStudents.FormattingEnabled = true;
            this.ListBoxStudents.ItemHeight = 17;
            this.ListBoxStudents.Location = new System.Drawing.Point(0, 0);
            this.ListBoxStudents.Name = "ListBoxStudents";
            this.ListBoxStudents.Size = new System.Drawing.Size(263, 480);
            this.ListBoxStudents.TabIndex = 0;
            this.ListBoxStudents.SelectedIndexChanged += new System.EventHandler(this.ListBoxStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ФИО*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Место жительства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(309, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "ФИО родителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(309, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(980, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Группа*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(855, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "* - обязательные поля";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPrint.Location = new System.Drawing.Point(291, 547);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(127, 35);
            this.ButtonPrint.TabIndex = 23;
            this.ButtonPrint.Text = "Печать";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CheckBoxStudentsDormitory
            // 
            this.CheckBoxStudentsDormitory.AutoSize = true;
            this.CheckBoxStudentsDormitory.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxStudentsDormitory.Location = new System.Drawing.Point(309, 279);
            this.CheckBoxStudentsDormitory.Name = "CheckBoxStudentsDormitory";
            this.CheckBoxStudentsDormitory.Size = new System.Drawing.Size(257, 29);
            this.CheckBoxStudentsDormitory.TabIndex = 24;
            this.CheckBoxStudentsDormitory.Text = "необходимо ли общежитие";
            this.CheckBoxStudentsDormitory.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.CheckBoxStudentsDormitory);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ListBoxGroups);
            this.Controls.Add(this.ComboBoxGroups);
            this.Controls.Add(this.TextBoxParentPhone);
            this.Controls.Add(this.TextBoxParentFIO);
            this.Controls.Add(this.TextBoxStudentsResidence);
            this.Controls.Add(this.TextBoxStudentsPhone);
            this.Controls.Add(this.TextBoxStudentsFIO);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ComboBoxSorting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.Text = "Students";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxSorting;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxStudentsFIO;
        private System.Windows.Forms.TextBox TextBoxStudentsPhone;
        private System.Windows.Forms.TextBox TextBoxStudentsResidence;
        private System.Windows.Forms.TextBox TextBoxParentFIO;
        private System.Windows.Forms.TextBox TextBoxParentPhone;
        private System.Windows.Forms.ComboBox ComboBoxGroups;
        private System.Windows.Forms.ListBox ListBoxGroups;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.CheckBox CheckBoxStudentsDormitory;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}