namespace kursach.Pages
{
    partial class Teachers
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
            this.ListBoxTeachers = new System.Windows.Forms.ListBox();
            this.ComboBoxSorting = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxFIO = new System.Windows.Forms.TextBox();
            this.TextBoxMail = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.CheckBoxAdmin = new System.Windows.Forms.CheckBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxTeachers
            // 
            this.ListBoxTeachers.FormattingEnabled = true;
            this.ListBoxTeachers.ItemHeight = 15;
            this.ListBoxTeachers.Location = new System.Drawing.Point(24, 58);
            this.ListBoxTeachers.Name = "ListBoxTeachers";
            this.ListBoxTeachers.Size = new System.Drawing.Size(246, 484);
            this.ListBoxTeachers.TabIndex = 0;
            this.ListBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.ListBoxTeachers_SelectedIndexChanged);
            // 
            // ComboBoxSorting
            // 
            this.ComboBoxSorting.FormattingEnabled = true;
            this.ComboBoxSorting.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.ComboBoxSorting.Location = new System.Drawing.Point(24, 18);
            this.ComboBoxSorting.Name = "ComboBoxSorting";
            this.ComboBoxSorting.Size = new System.Drawing.Size(246, 23);
            this.ComboBoxSorting.TabIndex = 1;
            this.ComboBoxSorting.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSorting_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(24, 549);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(120, 35);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(150, 549);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(120, 35);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Location = new System.Drawing.Point(385, 58);
            this.TextBoxFIO.Multiline = true;
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.PlaceholderText = "Иванов Иван Иванович";
            this.TextBoxFIO.Size = new System.Drawing.Size(557, 35);
            this.TextBoxFIO.TabIndex = 4;
            this.TextBoxFIO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFIO_KeyUp);
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Location = new System.Drawing.Point(385, 136);
            this.TextBoxMail.Multiline = true;
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.PlaceholderText = "....@...";
            this.TextBoxMail.Size = new System.Drawing.Size(220, 35);
            this.TextBoxMail.TabIndex = 5;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(722, 136);
            this.TextBoxPhone.Multiline = true;
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.PlaceholderText = "89999999999";
            this.TextBoxPhone.Size = new System.Drawing.Size(220, 35);
            this.TextBoxPhone.TabIndex = 6;
            this.TextBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(385, 245);
            this.TextBoxLogin.Multiline = true;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(220, 35);
            this.TextBoxLogin.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(385, 300);
            this.TextBoxPassword.Multiline = true;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(220, 35);
            this.TextBoxPassword.TabIndex = 8;
            // 
            // CheckBoxAdmin
            // 
            this.CheckBoxAdmin.AutoSize = true;
            this.CheckBoxAdmin.Location = new System.Drawing.Point(385, 378);
            this.CheckBoxAdmin.Name = "CheckBoxAdmin";
            this.CheckBoxAdmin.Size = new System.Drawing.Size(211, 19);
            this.CheckBoxAdmin.TabIndex = 9;
            this.CheckBoxAdmin.Text = "Доступ к панели администратора";
            this.CheckBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(1062, 532);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(120, 35);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "* - обязательные для заполнения поля";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.CheckBoxAdmin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxMail);
            this.Controls.Add(this.TextBoxFIO);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ComboBoxSorting);
            this.Controls.Add(this.ListBoxTeachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxTeachers;
        private System.Windows.Forms.ComboBox ComboBoxSorting;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxFIO;
        private System.Windows.Forms.TextBox TextBoxMail;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.CheckBox CheckBoxAdmin;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}