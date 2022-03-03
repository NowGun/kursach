using kursach.Classes;
using kursach.DataBase;
using Microsoft.EntityFrameworkCore;
using NickBuhro.Translit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.Pages
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            ListBoxTeachersRefresh();
        }

        List<int> idTeachers = new List<int>();

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            DataBaseControls DbControls = new DataBaseControls();

            if (!string.IsNullOrWhiteSpace(TextBoxFIO.Text) && !string.IsNullOrWhiteSpace(TextBoxMail.Text) && !string.IsNullOrWhiteSpace(TextBoxLogin.Text))
            {
                if (TextBoxFIO.Text.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                {
                    string[] FIO = TextBoxFIO.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (ListBoxTeachers.SelectedItem != null)
                    {
                        using (zhirov_cwContext db = new zhirov_cwContext())
                        {
                            Teacher? teacher = await db.Teachers.FirstOrDefaultAsync(p => p.Idteachers == idTeachers[ListBoxTeachers.SelectedIndex]);

                            if (teacher != null)
                            {
                                teacher.TeachersName = FIO[1];
                                teacher.TeachersSurname = FIO[0];
                                teacher.TeachersPatronymic = FIO[2];
                                teacher.TeachersAccesAdminPanel = CheckBoxAdmin.Checked.ToString();
                                teacher.TeachersPhone = TextBoxPhone.Text;
                                teacher.TeachersMail = TextBoxMail.Text;

                                await db.SaveChangesAsync();

                                ListBoxTeachersRefresh();
                            }
                        }
                    }
                    else
                    {
                        using (zhirov_cwContext db = new zhirov_cwContext())
                        {
                            var teac = await db.Teachers.Where(p => p.TeachersLogin == TextBoxLogin.Text).ToListAsync();

                            Teacher teacher = new Teacher
                            {
                                TeachersName = FIO[1],
                                TeachersSurname = FIO[0],
                                TeachersPatronymic = FIO[2],
                                TeachersLogin = TextBoxLogin.Text,
                                TeachersPassword = DbControls.Hash(TextBoxPassword.Text),
                                TeachersMail = TextBoxMail.Text,
                                TeachersPhone = TextBoxPhone.Text,
                                TeachersAccesAdminPanel = CheckBoxAdmin.Checked.ToString()
                            };

                            if (teac.Count == 0)
                            {
                                await db.Teachers.AddAsync(teacher);
                                await db.SaveChangesAsync();

                                SendPasswordToUser();
                                //SendSMSToUser();

                                TextBoxFIO.Clear();
                                TextBoxPhone.Clear();
                                TextBoxMail.Clear();
                                TextBoxLogin.Clear();
                                TextBoxPassword.Clear();
                                CheckBoxAdmin.Checked = false;
                                ListBoxTeachersRefresh();
                            }
                            //else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Данный логин уже занят");
                        }
                    }
                }
                //else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Поле ФИО должно быть в формате: Фамилия - Имя - Отчество");
            }
            //else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Заполните поля помеченные *");

        }

        private async void ListBoxTeachersRefresh()
        {
            ListBoxTeachers.Items.Clear();
            idTeachers.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                switch (ComboBoxSorting.SelectedIndex)
                {
                    case 0:
                        await db.Teachers.OrderBy(t => t.TeachersSurname).ForEachAsync(t =>
                        {
                            ListBoxTeachers.Items.Add($"{t.TeachersSurname} {t.TeachersName} {t.TeachersPatronymic}");
                            idTeachers.Add((int)t.Idteachers);
                        });
                        break;
                    case 1:
                        await db.Teachers.OrderByDescending(t => t.TeachersSurname).ForEachAsync(t =>
                        {
                            ListBoxTeachers.Items.Add($"{t.TeachersSurname} {t.TeachersName} {t.TeachersPatronymic}");
                            idTeachers.Add((int)t.Idteachers);
                        });
                        break;
                }
            }
        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            //if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void TextBoxFIO_KeyUp(object sender, KeyEventArgs e)
        {
            if (ListBoxTeachers.SelectedItem == null)
            {
                TextBoxPassword.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Guid.NewGuid().ToString())).Remove(8);

                TextBoxLogin.Text = Transliteration.CyrillicToLatin(TextBoxFIO.Text.Split().First(), NickBuhro.Translit.Language.Russian);
            }
        }

        private async void SendPasswordToUser()
        {
            try
            {
                string user = "User";
                bool a = true;
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("zhirowdaniil@gmail.com", user);
                // кому отправляем

                MailAddress to = new MailAddress(TextBoxMail.Text);

                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Новый пользователь";
                // текст письма
                m.Body = "Добро пожаловать в систему Электронный журнал\n\nАдминистратор зарегистрировал Вас в системе электронного журнала, ниже написаны данные для входа в вашу учетную запись.\nМы рекомендуем при первой возможности поменять пароль на более удобный Вам, так как нынешний пароль является временным." +
                    "\n\nЛогин: " + TextBoxLogin.Text + "\nПароль: " + TextBoxPassword.Text + "\n\n\n\n";
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.elasticemail.com", 2525);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("zhirowdaniil@gmail.com", "E0E7027197724CDBDAFAD917FB914057C0CB");
                smtp.EnableSsl = true;

                await Task.Run(() =>
                {
                    try
                    {
                        smtp.Send(m);
                    }
                    catch (SmtpException)
                    {
                        a = true;
                    }
                });

                if (a)
                {
                    //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "письмо отправлено");
                    //ButtonSend.Enabled = true;
                    //anim.Begin();
                    //RectangleLoad.Visibility = Visibility.Hidden;
                }
                else if (!a)
                {
                    //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "письмо не отправилось");
                    //ButtonSend.Enabled = true;
                    //anim.Begin();
                    //RectangleLoad.Visibility = Visibility.Hidden;
                }
            }
            catch (System.FormatException)
            {
                //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Введен некорректный Email");
            }
        }

        private void SendSMSToUser() // СТОИТ ОЧЕНЬ ДОРОГО, ИСПОЛЬЗОВАТЬ ТОЛЬКО В КРАЙНИХ СЛУЧАЯХ!!!!
        {
            string myApiKey = "B0361252-C8BA-5438-E643-4651FCC4E55B"; //Ваш API ключ
            SmsRu.SmsRu sms = new SmsRu.SmsRu(myApiKey);
            var response = sms.Send(TextBoxPhone.Text, "Добро пожаловать в Электронный журнал\n\nЛогин: " + TextBoxLogin.Text + "\nПароль: " + TextBoxPassword.Text);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ListBoxTeachers.SelectedItem = null;
            TextBoxFIO.Clear();
            TextBoxPhone.Clear();
            TextBoxMail.Clear();
            TextBoxLogin.Clear();
            TextBoxPassword.Clear();
            CheckBoxAdmin.Checked = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteTeachers();
        }

        private async void ListBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonDelete.Enabled = true;

            if (ListBoxTeachers.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    var teachers = await db.Teachers.Where(p => p.Idteachers == idTeachers[ListBoxTeachers.SelectedIndex]).ToListAsync();

                    foreach (var t in teachers)
                    {
                        string FIO = t.TeachersSurname + " " + t.TeachersName + " " + t.TeachersPatronymic;

                        TextBoxFIO.Text = FIO;
                        TextBoxLogin.Text = t.TeachersLogin;
                        TextBoxPassword.Text = t.TeachersPassword;
                        CheckBoxAdmin.Checked = bool.Parse(t.TeachersAccesAdminPanel);
                        TextBoxMail.Text = t.TeachersMail;
                        TextBoxPhone.Text = t.TeachersPhone;
                    }
                }
            }
        }

        private void ComboBoxSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxTeachersRefresh();
        }

        private async void DeleteTeachers()
        {
            if (ListBoxTeachers.Items.Count == 0)
            {
                //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Произошла ошибка");
            }
            else if (ListBoxTeachers.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    Teacher? teacher = await db.Teachers.FirstOrDefaultAsync(p => p.Idteachers == idTeachers[ListBoxTeachers.SelectedIndex]);

                    if (teacher != null)
                    {
                        db.Teachers.Remove(teacher);
                        await db.SaveChangesAsync();

                        ListBoxTeachers.Items.Clear();
                        ListBoxTeachersRefresh();
                        TextBoxFIO.Clear();
                        TextBoxPhone.Clear();
                        TextBoxMail.Clear();
                        TextBoxLogin.Clear();
                        TextBoxPassword.Clear();
                        CheckBoxAdmin.Checked = false;
                        ButtonDelete.Enabled = false;
                    }
                }
            }
        }
    }
}
