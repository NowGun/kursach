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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
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
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxTeachers
            // 
            this.ListBoxTeachers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxTeachers.FormattingEnabled = true;
            this.ListBoxTeachers.ItemHeight = 17;
            this.ListBoxTeachers.Location = new System.Drawing.Point(0, 0);
            this.ListBoxTeachers.Margin = new System.Windows.Forms.Padding(10);
            this.ListBoxTeachers.Name = "ListBoxTeachers";
            this.ListBoxTeachers.Size = new System.Drawing.Size(279, 480);
            this.ListBoxTeachers.TabIndex = 0;
            this.ListBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.ListBoxTeachers_SelectedIndexChanged);
            // 
            // ComboBoxSorting
            // 
            this.ComboBoxSorting.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxSorting.FormattingEnabled = true;
            this.ComboBoxSorting.Items.AddRange(new object[] {
            "А-Я",
            "Я-А"});
            this.ComboBoxSorting.Location = new System.Drawing.Point(24, 18);
            this.ComboBoxSorting.Name = "ComboBoxSorting";
            this.ComboBoxSorting.Size = new System.Drawing.Size(279, 31);
            this.ComboBoxSorting.TabIndex = 1;
            this.ComboBoxSorting.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSorting_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.Location = new System.Drawing.Point(24, 549);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 35);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.Location = new System.Drawing.Point(175, 548);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(128, 35);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFIO.Location = new System.Drawing.Point(414, 79);
            this.TextBoxFIO.Multiline = true;
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.PlaceholderText = "Иванов Иван Иванович";
            this.TextBoxFIO.Size = new System.Drawing.Size(557, 35);
            this.TextBoxFIO.TabIndex = 4;
            this.TextBoxFIO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFIO_KeyUp);
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMail.Location = new System.Drawing.Point(414, 145);
            this.TextBoxMail.Multiline = true;
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.PlaceholderText = "....@...";
            this.TextBoxMail.Size = new System.Drawing.Size(216, 35);
            this.TextBoxMail.TabIndex = 5;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPhone.Location = new System.Drawing.Point(829, 145);
            this.TextBoxPhone.Multiline = true;
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.PlaceholderText = "89999999999";
            this.TextBoxPhone.Size = new System.Drawing.Size(142, 35);
            this.TextBoxPhone.TabIndex = 6;
            this.TextBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxLogin.Location = new System.Drawing.Point(426, 257);
            this.TextBoxLogin.Multiline = true;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(216, 35);
            this.TextBoxLogin.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(426, 309);
            this.TextBoxPassword.Multiline = true;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(216, 35);
            this.TextBoxPassword.TabIndex = 8;
            // 
            // CheckBoxAdmin
            // 
            this.CheckBoxAdmin.AutoSize = true;
            this.CheckBoxAdmin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxAdmin.Location = new System.Drawing.Point(346, 378);
            this.CheckBoxAdmin.Name = "CheckBoxAdmin";
            this.CheckBoxAdmin.Size = new System.Drawing.Size(304, 29);
            this.CheckBoxAdmin.TabIndex = 9;
            this.CheckBoxAdmin.Text = "Доступ к панели администратора";
            this.CheckBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(829, 470);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(142, 35);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(346, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Почта*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(673, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(346, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Логин*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(346, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(346, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "* - обязательные для заполнения поля";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPrint.Location = new System.Drawing.Point(309, 549);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(128, 35);
            this.ButtonPrint.TabIndex = 17;
            this.ButtonPrint.Text = "Печать";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxTeachers);
            this.panel1.Location = new System.Drawing.Point(24, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 479);
            this.panel1.TabIndex = 18;
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
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPrint);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}