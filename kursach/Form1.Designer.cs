namespace kursach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.RadioButtonDiscipline = new System.Windows.Forms.RadioButton();
            this.LabelName = new System.Windows.Forms.Label();
            this.RadioButtonGroups = new System.Windows.Forms.RadioButton();
            this.RadioButtonStudents = new System.Windows.Forms.RadioButton();
            this.RadioButtonTeachers = new System.Windows.Forms.RadioButton();
            this.RadioButtonJournal = new System.Windows.Forms.RadioButton();
            this.content = new System.Windows.Forms.Panel();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.RadioButtonDiscipline);
            this.PanelMenu.Controls.Add(this.LabelName);
            this.PanelMenu.Controls.Add(this.RadioButtonGroups);
            this.PanelMenu.Controls.Add(this.RadioButtonStudents);
            this.PanelMenu.Controls.Add(this.RadioButtonTeachers);
            this.PanelMenu.Controls.Add(this.RadioButtonJournal);
            this.PanelMenu.Location = new System.Drawing.Point(1, -1);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1261, 56);
            this.PanelMenu.TabIndex = 0;
            // 
            // RadioButtonDiscipline
            // 
            this.RadioButtonDiscipline.AutoSize = true;
            this.RadioButtonDiscipline.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonDiscipline.Location = new System.Drawing.Point(497, 13);
            this.RadioButtonDiscipline.Name = "RadioButtonDiscipline";
            this.RadioButtonDiscipline.Size = new System.Drawing.Size(115, 29);
            this.RadioButtonDiscipline.TabIndex = 5;
            this.RadioButtonDiscipline.TabStop = true;
            this.RadioButtonDiscipline.Text = "Предметы";
            this.RadioButtonDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonDiscipline.UseVisualStyleBackColor = true;
            this.RadioButtonDiscipline.Click += new System.EventHandler(this.RadioButtonDiscipline_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSize = true;
            this.LabelName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(1192, 0);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Padding = new System.Windows.Forms.Padding(0, 15, 10, 0);
            this.LabelName.Size = new System.Drawing.Size(69, 40);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "label1";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // RadioButtonGroups
            // 
            this.RadioButtonGroups.AutoSize = true;
            this.RadioButtonGroups.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonGroups.Location = new System.Drawing.Point(400, 13);
            this.RadioButtonGroups.Name = "RadioButtonGroups";
            this.RadioButtonGroups.Size = new System.Drawing.Size(91, 29);
            this.RadioButtonGroups.TabIndex = 3;
            this.RadioButtonGroups.TabStop = true;
            this.RadioButtonGroups.Text = "Группы";
            this.RadioButtonGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonGroups.UseVisualStyleBackColor = true;
            this.RadioButtonGroups.Click += new System.EventHandler(this.RadioButtonGroups_Click);
            // 
            // RadioButtonStudents
            // 
            this.RadioButtonStudents.AutoSize = true;
            this.RadioButtonStudents.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonStudents.Location = new System.Drawing.Point(288, 13);
            this.RadioButtonStudents.Name = "RadioButtonStudents";
            this.RadioButtonStudents.Size = new System.Drawing.Size(106, 29);
            this.RadioButtonStudents.TabIndex = 2;
            this.RadioButtonStudents.TabStop = true;
            this.RadioButtonStudents.Text = "Студенты";
            this.RadioButtonStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonStudents.UseVisualStyleBackColor = true;
            this.RadioButtonStudents.Click += new System.EventHandler(this.RadioButtonStudents_Click);
            // 
            // RadioButtonTeachers
            // 
            this.RadioButtonTeachers.AutoSize = true;
            this.RadioButtonTeachers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonTeachers.Location = new System.Drawing.Point(125, 13);
            this.RadioButtonTeachers.Name = "RadioButtonTeachers";
            this.RadioButtonTeachers.Size = new System.Drawing.Size(157, 29);
            this.RadioButtonTeachers.TabIndex = 1;
            this.RadioButtonTeachers.TabStop = true;
            this.RadioButtonTeachers.Text = "Преподаватели";
            this.RadioButtonTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonTeachers.UseVisualStyleBackColor = true;
            this.RadioButtonTeachers.Click += new System.EventHandler(this.RadioButtonTeachers_Click);
            // 
            // RadioButtonJournal
            // 
            this.RadioButtonJournal.AutoSize = true;
            this.RadioButtonJournal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonJournal.Location = new System.Drawing.Point(25, 13);
            this.RadioButtonJournal.Name = "RadioButtonJournal";
            this.RadioButtonJournal.Size = new System.Drawing.Size(94, 29);
            this.RadioButtonJournal.TabIndex = 0;
            this.RadioButtonJournal.TabStop = true;
            this.RadioButtonJournal.Text = "Журнал";
            this.RadioButtonJournal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonJournal.UseVisualStyleBackColor = true;
            this.RadioButtonJournal.Click += new System.EventHandler(this.RadioButtonJournal_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(26, 64);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1213, 595);
            this.content.TabIndex = 1;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Controls.Add(this.TextBoxPassword);
            this.PanelLogin.Controls.Add(this.TextBoxLogin);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Location = new System.Drawing.Point(479, 233);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(322, 254);
            this.PanelLogin.TabIndex = 2;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(149, 185);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(120, 35);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(49, 144);
            this.TextBoxPassword.Multiline = true;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(220, 35);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.Text = "admin";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxLogin.Location = new System.Drawing.Point(49, 63);
            this.TextBoxLogin.Multiline = true;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PlaceholderText = "Логин";
            this.TextBoxLogin.Size = new System.Drawing.Size(220, 35);
            this.TextBoxLogin.TabIndex = 2;
            this.TextBoxLogin.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин";
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.content);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
	

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.RadioButton RadioButtonJournal;
        private System.Windows.Forms.RadioButton RadioButtonGroups;
        private System.Windows.Forms.RadioButton RadioButtonStudents;
        private System.Windows.Forms.RadioButton RadioButtonTeachers;
        private System.Windows.Forms.RadioButton RadioButtonDiscipline;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
