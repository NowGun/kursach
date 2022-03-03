using kursach.Classes;
using kursach.DataBase;
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

namespace kursach.Pages
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            ComboBoxSorting.SelectedIndex = 0;
            FillComboBoxStudents();
        }

        List<int> idStudents = new List<int>();
        List<int> idGroups = new List<int>();

        private async void ListBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonDelete.Enabled = true;

            if (ListBoxStudents.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    var students = await db.Students.Where(p => p.Idstudents == idStudents[ListBoxStudents.SelectedIndex]).ToListAsync();

                    foreach (var t in students)
                    {
                        string FIO = t.StudentsSurname + " " + t.StudentsName + " " + t.StudentsPatronymic;
                        int indexGroup = idGroups.IndexOf((int)t.GroupsIdgroups);


                        TextBoxStudentsFIO.Text = FIO;
                        TextBoxStudentsResidence.Text = t.StudentsResidence;
                        CheckBoxStudentsDormitory.Checked = bool.Parse(t.StudentsDormitory);
                        TextBoxParentFIO.Text = t.StudentsParent;
                        TextBoxStudentsPhone.Text = t.StudentsPhone;
                        TextBoxParentPhone.Text = t.StudentsParentPhone;
                        ListBoxGroups.SelectedIndex = indexGroup;
                    }
                }
            }
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            DataBaseControls DbControls = new DataBaseControls();

            if (!string.IsNullOrWhiteSpace(TextBoxStudentsFIO.Text))
            {
                if (TextBoxStudentsFIO.Text.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                {
                    string[] FIO = TextBoxStudentsFIO.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (ListBoxStudents.SelectedItem != null)
                    {
                        using (zhirov_cwContext db = new zhirov_cwContext())
                        {
                            Student? student = await db.Students.FirstOrDefaultAsync(p => p.Idstudents == idStudents[ListBoxStudents.SelectedIndex]);

                            if (student != null)
                            {
                                student.StudentsName = FIO[1];
                                student.StudentsSurname = FIO[0];
                                student.StudentsPatronymic = FIO[2];
                                student.StudentsParentPhone = TextBoxParentPhone.Text;
                                student.StudentsPhone = TextBoxStudentsPhone.Text;
                                student.StudentsParent = TextBoxParentFIO.Text;
                                student.StudentsDormitory = CheckBoxStudentsDormitory.Checked.ToString();
                                student.StudentsResidence = TextBoxStudentsResidence.Text;
                                student.GroupsIdgroups = (uint)idGroups[ListBoxGroups.SelectedIndex];

                                await db.SaveChangesAsync();

                                ListBoxStudentsRefresh();
                                //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Уведомление", "Сохранено");
                            }
                        }
                    }
                    else
                    {
                        using (zhirov_cwContext db = new zhirov_cwContext())
                        {
                            Student students = new Student
                            {
                                StudentsName = FIO[1],
                                StudentsSurname = FIO[0],
                                StudentsPatronymic = FIO[2],
                                StudentsParentPhone = TextBoxParentPhone.Text,
                                StudentsPhone = TextBoxStudentsPhone.Text,
                                StudentsParent = TextBoxParentFIO.Text,
                                StudentsDormitory = CheckBoxStudentsDormitory.Checked.ToString(),
                                StudentsResidence = TextBoxStudentsResidence.Text,
                                GroupsIdgroups = (uint)idGroups[ListBoxGroups.SelectedIndex]
                            };

                            await db.Students.AddAsync(students);
                            await db.SaveChangesAsync();

                            ListBoxStudentsRefresh();
                            TextBoxParentFIO.Clear();
                            TextBoxParentPhone.Clear();
                            TextBoxStudentsFIO.Clear();
                            TextBoxStudentsPhone.Clear();
                            TextBoxStudentsResidence.Clear();
                            CheckBoxStudentsDormitory.Checked = false;

                            //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Данные сохранены");
                        }
                    }
                }
               // else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Поле ФИО должно быть в формате: Фамилия - Имя - Отчество");
            }
            //else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Заполните поля помеченные *");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ListBoxStudents.SelectedItem = null;
            TextBoxParentFIO.Clear();
            TextBoxParentPhone.Clear();
            TextBoxStudentsFIO.Clear();
            TextBoxStudentsPhone.Clear();
            TextBoxStudentsResidence.Clear();
            CheckBoxStudentsDormitory.Checked = false;
        }

        private async void ListBoxStudentsRefresh()
        {
            ListBoxStudents.Items.Clear();
            idStudents.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                switch (ComboBoxSorting.SelectedIndex)
                {
                    case 0:
                        await db.Students.OrderBy(t => t.StudentsSurname).ForEachAsync(t =>
                        {
                            ListBoxStudents.Items.Add($"{t.StudentsSurname} {t.StudentsName} {t.StudentsPatronymic}");
                            idStudents.Add((int)t.Idstudents);
                        });
                        break;
                    case 1:
                        await db.Students.OrderByDescending(t => t.StudentsSurname).ForEachAsync(t =>
                        {
                            ListBoxStudents.Items.Add($"{t.StudentsSurname} {t.StudentsName} {t.StudentsPatronymic}");
                            idStudents.Add((int)t.Idstudents);
                        });
                        break;
                }
            }
        }

        private void ComboBoxSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxStudentsRefresh();
        }

        private async void DeleteStudent()
        {
            if (ListBoxStudents.Items.Count == 0)
            {
                //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Произошла ошибка");
            }
            else if (ListBoxStudents.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    Student? student = await db.Students.FirstOrDefaultAsync(p => p.Idstudents == idStudents[ListBoxStudents.SelectedIndex]);

                    if (student != null)
                    {
                        db.Students.Remove(student);
                        await db.SaveChangesAsync();

                        ListBoxStudents.Items.Clear();
                        ListBoxStudentsRefresh();
                        TextBoxParentFIO.Clear();
                        TextBoxParentPhone.Clear();
                        TextBoxStudentsFIO.Clear();
                        TextBoxStudentsPhone.Clear();
                        TextBoxStudentsResidence.Clear();
                        CheckBoxStudentsDormitory.Checked = false;
                    }
                }
            }
        }

        private async void FillComboBoxStudents()
        {
            ComboBoxGroups.Items.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Courses.OrderBy(t => t.CourseName).ForEachAsync(t =>
                {
                    ComboBoxGroups.Items.Add(t.CourseName);
                });
            }
        }



        private async void FillListBox()
        {
            ListBoxGroups.Items.Clear();
            idGroups.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Groups.Where(p => p.CourseIdcourseNavigation.CourseName == ComboBoxGroups.SelectedItem.ToString()).ForEachAsync(p =>
                {
                    ListBoxGroups.Items.Add(p.GroupsNameAbbreviated);
                    idGroups.Add((int)p.Idgroups);
                });
            }
        }

        private void ComboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox();
            ListBoxGroups.Visible = true;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            var bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bitmap, new Rectangle(panel1.Location, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }
    }
}
