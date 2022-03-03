namespace kursach.Pages
{
    partial class Groups
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
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxGroups = new System.Windows.Forms.ListBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxGroupsPrefix = new System.Windows.Forms.TextBox();
            this.TextBoxGroupsNameAbbreviated = new System.Windows.Forms.TextBox();
            this.TextBoxGroupsName = new System.Windows.Forms.TextBox();
            this.ButtonGroupDelete = new System.Windows.Forms.Button();
            this.ButonGroupAdd = new System.Windows.Forms.Button();
            this.ComboBoxGroupsSorting = new System.Windows.Forms.ComboBox();
            this.ComboBoxClassTeacher = new System.Windows.Forms.ComboBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxTypeLearning = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPrint.Location = new System.Drawing.Point(283, 548);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(127, 35);
            this.ButtonPrint.TabIndex = 44;
            this.ButtonPrint.Text = "Печать";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(384, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "* - обязательные поля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(655, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Классный Руководитель*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(384, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Сокращенное название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(384, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Полное название группы*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxGroups);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 493);
            this.panel1.TabIndex = 36;
            // 
            // ListBoxGroups
            // 
            this.ListBoxGroups.FormattingEnabled = true;
            this.ListBoxGroups.ItemHeight = 17;
            this.ListBoxGroups.Location = new System.Drawing.Point(0, 2);
            this.ListBoxGroups.Name = "ListBoxGroups";
            this.ListBoxGroups.Size = new System.Drawing.Size(263, 480);
            this.ListBoxGroups.TabIndex = 0;
            this.ListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.ListBoxGroups_SelectedIndexChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(772, 472);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(146, 35);
            this.ButtonSave.TabIndex = 35;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxGroupsPrefix
            // 
            this.TextBoxGroupsPrefix.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxGroupsPrefix.Location = new System.Drawing.Point(384, 284);
            this.TextBoxGroupsPrefix.Multiline = true;
            this.TextBoxGroupsPrefix.Name = "TextBoxGroupsPrefix";
            this.TextBoxGroupsPrefix.Size = new System.Drawing.Size(228, 35);
            this.TextBoxGroupsPrefix.TabIndex = 31;
            // 
            // TextBoxGroupsNameAbbreviated
            // 
            this.TextBoxGroupsNameAbbreviated.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxGroupsNameAbbreviated.Location = new System.Drawing.Point(384, 193);
            this.TextBoxGroupsNameAbbreviated.Multiline = true;
            this.TextBoxGroupsNameAbbreviated.Name = "TextBoxGroupsNameAbbreviated";
            this.TextBoxGroupsNameAbbreviated.Size = new System.Drawing.Size(228, 35);
            this.TextBoxGroupsNameAbbreviated.TabIndex = 29;
            // 
            // TextBoxGroupsName
            // 
            this.TextBoxGroupsName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxGroupsName.Location = new System.Drawing.Point(384, 105);
            this.TextBoxGroupsName.Multiline = true;
            this.TextBoxGroupsName.Name = "TextBoxGroupsName";
            this.TextBoxGroupsName.Size = new System.Drawing.Size(534, 35);
            this.TextBoxGroupsName.TabIndex = 28;
            // 
            // ButtonGroupDelete
            // 
            this.ButtonGroupDelete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonGroupDelete.Location = new System.Drawing.Point(150, 548);
            this.ButtonGroupDelete.Name = "ButtonGroupDelete";
            this.ButtonGroupDelete.Size = new System.Drawing.Size(127, 35);
            this.ButtonGroupDelete.TabIndex = 27;
            this.ButtonGroupDelete.Text = "Удалить";
            this.ButtonGroupDelete.UseVisualStyleBackColor = true;
            this.ButtonGroupDelete.Click += new System.EventHandler(this.ButtonGroupDelete_Click);
            // 
            // ButonGroupAdd
            // 
            this.ButonGroupAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButonGroupAdd.Location = new System.Drawing.Point(12, 548);
            this.ButonGroupAdd.Name = "ButonGroupAdd";
            this.ButonGroupAdd.Size = new System.Drawing.Size(120, 35);
            this.ButonGroupAdd.TabIndex = 26;
            this.ButonGroupAdd.Text = "Добавить";
            this.ButonGroupAdd.UseVisualStyleBackColor = true;
            this.ButonGroupAdd.Click += new System.EventHandler(this.ButonGroupAdd_Click);
            // 
            // ComboBoxGroupsSorting
            // 
            this.ComboBoxGroupsSorting.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxGroupsSorting.FormattingEnabled = true;
            this.ComboBoxGroupsSorting.Items.AddRange(new object[] {
            "Все курсы",
            "1 курс",
            "2 курс",
            "3 курс",
            "4 курс"});
            this.ComboBoxGroupsSorting.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxGroupsSorting.Name = "ComboBoxGroupsSorting";
            this.ComboBoxGroupsSorting.Size = new System.Drawing.Size(263, 31);
            this.ComboBoxGroupsSorting.TabIndex = 25;
            this.ComboBoxGroupsSorting.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroupsSorting_SelectedIndexChanged);
            // 
            // ComboBoxClassTeacher
            // 
            this.ComboBoxClassTeacher.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxClassTeacher.FormattingEnabled = true;
            this.ComboBoxClassTeacher.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.ComboBoxClassTeacher.Location = new System.Drawing.Point(655, 197);
            this.ComboBoxClassTeacher.Name = "ComboBoxClassTeacher";
            this.ComboBoxClassTeacher.Size = new System.Drawing.Size(263, 31);
            this.ComboBoxClassTeacher.TabIndex = 46;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.ComboBoxCourse.Location = new System.Drawing.Point(655, 288);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(263, 31);
            this.ComboBoxCourse.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(655, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Курс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(384, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Индекс группы";
            // 
            // ComboBoxTypeLearning
            // 
            this.ComboBoxTypeLearning.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxTypeLearning.FormattingEnabled = true;
            this.ComboBoxTypeLearning.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.ComboBoxTypeLearning.Location = new System.Drawing.Point(384, 386);
            this.ComboBoxTypeLearning.Name = "ComboBoxTypeLearning";
            this.ComboBoxTypeLearning.Size = new System.Drawing.Size(263, 31);
            this.ComboBoxTypeLearning.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(384, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Форма обучения";
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.ComboBoxTypeLearning);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxClassTeacher);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxGroupsPrefix);
            this.Controls.Add(this.TextBoxGroupsNameAbbreviated);
            this.Controls.Add(this.TextBoxGroupsName);
            this.Controls.Add(this.ButtonGroupDelete);
            this.Controls.Add(this.ButonGroupAdd);
            this.Controls.Add(this.ComboBoxGroupsSorting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Groups";
            this.Text = "Groups";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBoxGroups;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxGroupsPrefix;
        private System.Windows.Forms.TextBox TextBoxGroupsNameAbbreviated;
        private System.Windows.Forms.TextBox TextBoxGroupsName;
        private System.Windows.Forms.Button ButtonGroupDelete;
        private System.Windows.Forms.Button ButonGroupAdd;
        private System.Windows.Forms.ComboBox ComboBoxGroupsSorting;
        private System.Windows.Forms.ComboBox ComboBoxClassTeacher;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxTypeLearning;
        private System.Windows.Forms.Label label9;
    }
}