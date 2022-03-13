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
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();
            ListBoxDisciplineRefresh();
        }

        List<int> idDiscipline = new List<int>();
        List<int> idGroups = new List<int>();

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void ButonDisciplineAdd_Click(object sender, EventArgs e)
        {
            ListBoxDiscipline.SelectedItem = null;
            TextBoxDisciplineName.Clear();
            TextBoxDisciplineNameAbbreviated.Clear();
            TextBoxDisciplinePrefix.Clear();
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            DataBaseControls DbControls = new DataBaseControls();

            if (!string.IsNullOrWhiteSpace(TextBoxDisciplineName.Text) && !string.IsNullOrWhiteSpace(TextBoxDisciplineNameAbbreviated.Text))
            {
                if (ListBoxDiscipline.SelectedItem != null)
                {
                    using (zhirov_cwContext db = new zhirov_cwContext())
                    {

                        DataBase.Discipline? dis = await db.Disciplines.FirstOrDefaultAsync(p => p.Iddisciplines == idDiscipline[ListBoxDiscipline.SelectedIndex]);

                        if (dis != null)
                        {
                            dis.DisciplinesName = TextBoxDisciplineName.Text;
                            dis.DisciplinesNameAbbreviated = TextBoxDisciplineNameAbbreviated.Text;
                            dis.DisciplinesIndex = TextBoxDisciplinePrefix.Text;

                            await db.SaveChangesAsync();

                            ListBoxDisciplineRefresh();
                            //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Уведомление", "Сохранено");
                        }
                    }
                }
                else
                {
                    using (zhirov_cwContext db = new zhirov_cwContext())
                    {
                        DataBase.Discipline dis = new DataBase.Discipline
                        {
                            DisciplinesName = TextBoxDisciplineName.Text,
                            DisciplinesNameAbbreviated = TextBoxDisciplineNameAbbreviated.Text,
                            DisciplinesIndex = TextBoxDisciplinePrefix.Text
                        };

                        await db.Disciplines.AddAsync(dis);
                        await db.SaveChangesAsync();

                        ListBoxDisciplineRefresh();
                        TextBoxDisciplineName.Clear();
                        TextBoxDisciplineNameAbbreviated.Clear();
                        TextBoxDisciplinePrefix.Clear();

                        //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Данные сохранены");
                    }
                }
            }
            //else ((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Заполните поля помеченные *");
        }

        private async void ListBoxDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonDisciplineDelete.Enabled = true;

            if (ListBoxDiscipline.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    var dis = await db.Disciplines.Where(p => p.Iddisciplines == idDiscipline[ListBoxDiscipline.SelectedIndex]).ToListAsync();

                    foreach (var t in dis)
                    {
                        int indexDis = idDiscipline.IndexOf((int)t.Iddisciplines);

                        TextBoxDisciplineName.Text = t.DisciplinesName;
                        TextBoxDisciplineNameAbbreviated.Text = t.DisciplinesNameAbbreviated;
                        TextBoxDisciplinePrefix.Text = t.DisciplinesIndex;
                    }
                }
            }
        }

        private void ButtonDisciplineDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private async void ListBoxDisciplineRefresh()
        {
            ListBoxDiscipline.Items.Clear();
            idDiscipline.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Disciplines.OrderBy(t => t.DisciplinesNameAbbreviated).ForEachAsync(t =>
                {
                    ListBoxDiscipline.Items.Add($"{t.DisciplinesNameAbbreviated}");
                    idDiscipline.Add((int)t.Iddisciplines);
                });
            }
        }

        private async void DeleteStudent()
        {
            if (ListBoxDiscipline.Items.Count == 0)
            {
                //((MainWindow)System.Windows.Application.Current.MainWindow).Notifications("Сообщение", "Произошла ошибка");
            }
            else if (ListBoxDiscipline.SelectedItem != null)
            {
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    DataBase.Discipline? dis = await db.Disciplines.FirstOrDefaultAsync(p => p.Iddisciplines == idDiscipline[ListBoxDiscipline.SelectedIndex]);

                    if (dis != null)
                    {
                        db.Disciplines.Remove(dis);
                        await db.SaveChangesAsync();

                        ListBoxDiscipline.Items.Clear();
                        ListBoxDisciplineRefresh();
                        TextBoxDisciplineName.Clear();
                        TextBoxDisciplineNameAbbreviated.Clear();
                        TextBoxDisciplinePrefix.Clear();
                    }
                }
            }
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
