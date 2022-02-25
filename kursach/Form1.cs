using kursach.Classes;
using kursach.DataBase;
using kursach.Pages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PanelMenu.Visible = false;
            content.Visible = false;
        }

        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void RadioButtonJournal_Click(object sender, EventArgs e)
        {
            Pages.Journal teacher = new Pages.Journal();
            nav(teacher, content);
        }

        private void RadioButtonTeachers_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();
            nav(teacher, content);
        }

        private void RadioButtonStudents_Click(object sender, EventArgs e)
        {
            Students teacher = new Students();
            nav(teacher, content);
        }

        private void RadioButtonGroups_Click(object sender, EventArgs e)
        {
            Groups teacher = new Groups();
            nav(teacher, content);
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            PanelMenu.Visible = false;
            content.Visible = false;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Login();

            
        }

        private void RadioButtonDiscipline_Click(object sender, EventArgs e)
        {
            Pages.Discipline teacher = new Pages.Discipline();
            nav(teacher, content);
        }

        private async void Login()
        {
            ButtonLogin.Enabled = false;
            TextBoxLogin.Enabled = false;
            TextBoxPassword.Enabled = false;
            DataBaseControls DbControls = new DataBaseControls();
            string pass = DbControls.Hash(TextBoxPassword.Text);

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                bool isAvalaible = await db.Database.CanConnectAsync();
                if (isAvalaible)
                {
                    if (!string.IsNullOrWhiteSpace(TextBoxLogin.Text) && TextBoxPassword.Text != string.Empty)
                    {
                        var login = await db.Teachers.Where(p => p.TeachersLogin == TextBoxLogin.Text && p.TeachersPassword == pass).ToListAsync();

                        if (login.Count != 0)
                        {
                            foreach (var l in login)
                            {
                                LabelName.Text = l.TeachersSurname + " " + l.TeachersName;

                                PanelLogin.Visible = false;
                                PanelMenu.Visible = true;
                                content.Visible = true;

                                RadioButtonJournal.Checked = true;
                                Pages.Journal teacher = new Pages.Journal();
                                nav(teacher, content);

                                TextBoxLogin.Enabled = true;
                                TextBoxPassword.Enabled = true;
                                ButtonLogin.Enabled = true;
                            }
                        }
                        else
                        {
                            //Notifications("Ошибка", "Логин или пароль введен неверно");
                            TextBoxLogin.Enabled = true;
                            TextBoxPassword.Enabled = true;
                            ButtonLogin.Enabled = true;
                        }
                    }
                    else
                    {
                        //Notifications("Ошибка", "Заполните поле");
                        TextBoxLogin.Enabled = true;
                        TextBoxPassword.Enabled = true;
                        ButtonLogin.Enabled = true;
                    }
                }
                else
                {
                    TextBoxLogin.Enabled = true;
                    TextBoxPassword.Enabled = true;
                    ButtonLogin.Enabled = true;
                    //Notifications("Ошибка", "База данных недоступна");
                }
            }
        }
    }
}
