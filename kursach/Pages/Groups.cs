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
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
            FillListBoxGroups();
            FillComboBoxCourse();
            FillComboBoxClassTeacher();
            FillComboBoxTypeLearning();
            ComboBoxGroupsSorting.SelectedIndex = 0;
        }

        List<int> idGroups = new List<int>();
        List<int> idTeachers = new List<int>();
        List<int> idTypeLearning = new List<int>();

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxGroupsName.Text) && ComboBoxClassTeacher.SelectedItem != null)
            {


                if (ListBoxGroups.SelectedItem != null)
                {
                    using (zhirov_cwContext db = new zhirov_cwContext())
                    {
                        Group? groups = await db.Groups.FirstOrDefaultAsync(p => p.Idgroups == idGroups[ListBoxGroups.SelectedIndex]);

                        if (groups != null)
                        {
                            groups.GroupsName = TextBoxGroupsName.Text;
                            groups.GroupsNameAbbreviated = TextBoxGroupsNameAbbreviated.Text;
                            groups.GroupsPrefix = TextBoxGroupsPrefix.Text;
                            //groups.CourseIdcourse = ComboBoxCourse.SelectedIndex;
                            //groups.TypelearningIdtypelearning = idTypeLearning[ComboBoxTypeLearning.SelectedIndex];
                            //groups.TeachersIdteachers = idTeachers[ComboBoxClassTeacher.SelectedIndex];

                            await db.SaveChangesAsync();

                            FillListBoxGroups();

                            TextBoxGroupsName.Clear();
                            TextBoxGroupsNameAbbreviated.Clear();
                            TextBoxGroupsPrefix.Clear();
                            ComboBoxTypeLearning.SelectedIndex = 0;
                            ComboBoxClassTeacher.SelectedItem = null;
                            ComboBoxCourse.SelectedIndex = 0;

                            //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Уведомление", "Сохранено");
                        }
                    }
                }
                else
                {
                    using (zhirov_cwContext db = new zhirov_cwContext())
                    {

                        Group gr = new Group
                        {

                        };


                        await db.Groups.AddAsync(gr);
                        await db.SaveChangesAsync();

                        FillListBoxGroups();

                        TextBoxGroupsName.Clear();
                        TextBoxGroupsNameAbbreviated.Clear();
                        TextBoxGroupsPrefix.Clear();
                        ComboBoxTypeLearning.SelectedIndex = 0;
                        ComboBoxClassTeacher.SelectedItem = null;
                        ComboBoxCourse.SelectedIndex = 0;

                        //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Уведомление", "Сохранено");

                        //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Данные сохранены");

                    }
                }

            }
           // else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Заполните поля помеченные *");
        }

        private void ButtonGroupDelete_Click(object sender, EventArgs e)
        {
            DeleteGroup();
        }

        private void ButonGroupAdd_Click(object sender, EventArgs e)
        {
            ListBoxGroups.SelectedItem = null;

            FillComboBoxClassTeacher();
            FillComboBoxTypeLearning();

            TextBoxGroupsName.Clear();
            TextBoxGroupsNameAbbreviated.Clear();
            TextBoxGroupsPrefix.Clear();
            ComboBoxTypeLearning.SelectedIndex = 0;
            ComboBoxClassTeacher.SelectedItem = null;
            ComboBoxCourse.SelectedIndex = 0;
        }

        private async void FillListBoxGroups()
        {
            ListBoxGroups.Items.Clear();
            idGroups.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                switch (ComboBoxGroupsSorting.SelectedIndex)
                {
                    case 0:
                        await db.Groups.OrderBy(t => t.GroupsNameAbbreviated).ForEachAsync(t =>
                        {
                            ListBoxGroups.Items.Add($"{t.GroupsNameAbbreviated}");
                            idGroups.Add((int)t.Idgroups);
                        });
                        break;
                    case 1:

                        break;
                }
            }
        }

        private async void FillComboBoxClassTeacher()
        {
            ComboBoxClassTeacher.Items.Clear();
            idTeachers.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Teachers.OrderBy(t => t.TeachersSurname).ForEachAsync(t =>
                {
                    ComboBoxClassTeacher.Items.Add($"{t.TeachersSurname} {t.TeachersName} {t.TeachersPatronymic}");
                    idTeachers.Add((int)t.Idteachers);
                });
            }
        }

        private async void FillComboBoxTypeLearning()
        {
            idTypeLearning.Clear();
            ComboBoxTypeLearning.Items.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Typelearnings.OrderBy(t => t.TypelearningName).ForEachAsync(t =>
                {
                    ComboBoxTypeLearning.Items.Add(t.TypelearningName);
                    idTypeLearning.Add((int)t.Idtypelearning);
                });

                ComboBoxTypeLearning.SelectedIndex = 0;
            }
        }

        private async void ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxGroups.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    var groups = await db.Groups.Where(p => p.Idgroups == idGroups[ListBoxGroups.SelectedIndex]).ToListAsync();

                    foreach (var t in groups)
                    {

                        TextBoxGroupsName.Text = t.GroupsName;
                        TextBoxGroupsNameAbbreviated.Text = t.GroupsNameAbbreviated;
                        TextBoxGroupsPrefix.Text = t.GroupsPrefix;
                        // ComboBoxTypeLearning.SelectedItem = t.TypelearningIdtypelearningNavigation.TypelearningName;
                        //ComboBoxClassTeacher.SelectedIndex = (int)t.TeachersIdteachers;
                    }
                }
            }
        }

        private async void DeleteGroup()
        {
            if (ListBoxGroups.Items.Count == 0)
            {
                //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Произошла ошибка");
            }
            else if (ListBoxGroups.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    Group? groups = await db.Groups.FirstOrDefaultAsync(p => p.Idgroups == idGroups[ListBoxGroups.SelectedIndex]);

                    if (groups != null)
                    {
                        db.Groups.Remove(groups);
                        await db.SaveChangesAsync();

                        ListBoxGroups.Items.Clear();
                        TextBoxGroupsName.Clear();
                        TextBoxGroupsNameAbbreviated.Clear();
                        TextBoxGroupsPrefix.Clear();
                        ComboBoxTypeLearning.SelectedIndex = 0;
                        ComboBoxClassTeacher.SelectedItem = null;
                        ComboBoxCourse.SelectedItem = null;
                        FillListBoxGroups();
                    }
                }
            }
        }

        private void ComboBoxGroupsSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBoxGroups();
        }

        private async void FillComboBoxCourse()
        {
            ComboBoxCourse.Items.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Courses.OrderBy(t => t.CourseName).ForEachAsync(t =>
                {
                    ComboBoxCourse.Items.Add(t.CourseName);
                });
            }
        }
    }
}
