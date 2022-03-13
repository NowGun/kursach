namespace kursach.Pages
{
    partial class Discipline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discipline));
            this.ListBoxDiscipline = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxDisciplinePrefix = new System.Windows.Forms.TextBox();
            this.TextBoxDisciplineNameAbbreviated = new System.Windows.Forms.TextBox();
            this.TextBoxDisciplineName = new System.Windows.Forms.TextBox();
            this.ButtonDisciplineDelete = new System.Windows.Forms.Button();
            this.ButonDisciplineAdd = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxDiscipline
            // 
            this.ListBoxDiscipline.FormattingEnabled = true;
            this.ListBoxDiscipline.ItemHeight = 15;
            this.ListBoxDiscipline.Location = new System.Drawing.Point(0, 0);
            this.ListBoxDiscipline.Name = "ListBoxDiscipline";
            this.ListBoxDiscipline.Size = new System.Drawing.Size(263, 529);
            this.ListBoxDiscipline.TabIndex = 50;
            this.ListBoxDiscipline.SelectedIndexChanged += new System.EventHandler(this.ListBoxDiscipline_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(304, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Индекс предмета";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPrint.Location = new System.Drawing.Point(291, 547);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(127, 35);
            this.ButtonPrint.TabIndex = 60;
            this.ButtonPrint.Text = "Печать";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(304, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "* - обязательные поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(304, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Сокращенное название*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(304, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Полное название предмета*";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(692, 482);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(146, 35);
            this.ButtonSave.TabIndex = 56;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxDisciplinePrefix
            // 
            this.TextBoxDisciplinePrefix.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDisciplinePrefix.Location = new System.Drawing.Point(304, 285);
            this.TextBoxDisciplinePrefix.Multiline = true;
            this.TextBoxDisciplinePrefix.Name = "TextBoxDisciplinePrefix";
            this.TextBoxDisciplinePrefix.Size = new System.Drawing.Size(260, 35);
            this.TextBoxDisciplinePrefix.TabIndex = 55;
            // 
            // TextBoxDisciplineNameAbbreviated
            // 
            this.TextBoxDisciplineNameAbbreviated.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDisciplineNameAbbreviated.Location = new System.Drawing.Point(304, 170);
            this.TextBoxDisciplineNameAbbreviated.Multiline = true;
            this.TextBoxDisciplineNameAbbreviated.Name = "TextBoxDisciplineNameAbbreviated";
            this.TextBoxDisciplineNameAbbreviated.Size = new System.Drawing.Size(534, 35);
            this.TextBoxDisciplineNameAbbreviated.TabIndex = 54;
            // 
            // TextBoxDisciplineName
            // 
            this.TextBoxDisciplineName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDisciplineName.Location = new System.Drawing.Point(304, 60);
            this.TextBoxDisciplineName.Multiline = true;
            this.TextBoxDisciplineName.Name = "TextBoxDisciplineName";
            this.TextBoxDisciplineName.Size = new System.Drawing.Size(534, 35);
            this.TextBoxDisciplineName.TabIndex = 53;
            // 
            // ButtonDisciplineDelete
            // 
            this.ButtonDisciplineDelete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDisciplineDelete.Location = new System.Drawing.Point(148, 547);
            this.ButtonDisciplineDelete.Name = "ButtonDisciplineDelete";
            this.ButtonDisciplineDelete.Size = new System.Drawing.Size(127, 35);
            this.ButtonDisciplineDelete.TabIndex = 52;
            this.ButtonDisciplineDelete.Text = "Удалить";
            this.ButtonDisciplineDelete.UseVisualStyleBackColor = true;
            this.ButtonDisciplineDelete.Click += new System.EventHandler(this.ButtonDisciplineDelete_Click);
            // 
            // ButonDisciplineAdd
            // 
            this.ButonDisciplineAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButonDisciplineAdd.Location = new System.Drawing.Point(12, 547);
            this.ButonDisciplineAdd.Name = "ButonDisciplineAdd";
            this.ButonDisciplineAdd.Size = new System.Drawing.Size(120, 35);
            this.ButonDisciplineAdd.TabIndex = 51;
            this.ButonDisciplineAdd.Text = "Добавить";
            this.ButonDisciplineAdd.UseVisualStyleBackColor = true;
            this.ButonDisciplineAdd.Click += new System.EventHandler(this.ButonDisciplineAdd_Click);
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxDiscipline);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 529);
            this.panel1.TabIndex = 62;
            // 
            // Discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1213, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxDisciplinePrefix);
            this.Controls.Add(this.TextBoxDisciplineNameAbbreviated);
            this.Controls.Add(this.TextBoxDisciplineName);
            this.Controls.Add(this.ButtonDisciplineDelete);
            this.Controls.Add(this.ButonDisciplineAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discipline";
            this.Text = "Discipline";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxDiscipline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxDisciplinePrefix;
        private System.Windows.Forms.TextBox TextBoxDisciplineNameAbbreviated;
        private System.Windows.Forms.TextBox TextBoxDisciplineName;
        private System.Windows.Forms.Button ButtonDisciplineDelete;
        private System.Windows.Forms.Button ButonDisciplineAdd;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}