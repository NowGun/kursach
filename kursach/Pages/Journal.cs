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
using unvell.ReoGrid;
using unvell.ReoGrid.Actions;

namespace kursach.Pages
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
            FillComoBoxMonth();
            ComboBoxMonth.SelectedIndex = DateTime.Now.Month - 1;
            FillTable();
            FillComboBoxGroups();
        }

        string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames;

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
        private void FillTable()
        {
            FillText();
            FillStudents();
            FillDates();
        }

        private async void FillStudents()
        {
            if (ComboBoxGroup.SelectedIndex != -1)
            {
                var worksheet = ReoGrid.CurrentWorksheet;
                using (zhirov_cwContext db = new zhirov_cwContext())
                {
                    var days = await db.Groups.Where(p => p.GroupsNameAbbreviated == ComboBoxGroup.SelectedItem.ToString()).Select(p => p.Idgroups).ToListAsync();
                    var students = await db.Students.Where(p => p.GroupsIdgroups == days[0]).ToListAsync();

                    for (int i = 2; i < students.Count; i++)
                    {
                        worksheet.SetRows(i);
                        worksheet["A" + i] = students[i].StudentsSurname + " " + students[i].StudentsName;
                        worksheet.AutoFitColumnWidth(0, false);

                        unvell.ReoGrid.Cell? cell = worksheet.Cells["A" + i];
                        cell.IsReadOnly = true;

                        worksheet.SetRangeStyles("A1:A" + i, new WorksheetRangeStyle
                        {
                            Flag = PlainStyleFlag.FontSize | PlainStyleFlag.FontName,
                            FontName = "Segoe UI",
                            FontSize = 14,
                        });
                    }

                }
            }
        }

        private async void FillDates()
        {
            var worksheet = ReoGrid.CurrentWorksheet;

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                var days = await db.Dates.Where(p => p.Month == ComboBoxMonth.SelectedIndex + 1 && p.Year == 2022).Select(p => p.Day).ToListAsync();

                for (int i = 1; i < days.Count + 1; i++)
                {
                    worksheet.SetCols(i + 1);
                    worksheet[0, i] = days[i - 1];
                    ReoGrid.DoAction(new SetColumnsWidthAction(1, i, 30));

                    unvell.ReoGrid.Cell? cell = worksheet.Cells[0, i];
                    cell.IsReadOnly = true;

                    worksheet.SetRangeStyles("B1:BP150", new WorksheetRangeStyle
                    {
                        Flag = PlainStyleFlag.HorizontalAlign,
                        HAlign = ReoGridHorAlign.Center,
                    });

                    worksheet.SetRangeStyles("B1:BP150", new WorksheetRangeStyle
                    {
                        Flag = PlainStyleFlag.FontSize | PlainStyleFlag.FontName,
                        FontName = "Segoe UI",
                        FontSize = 14,
                    });
                }
            }
        }

        private void FillText()
        {
            var worksheet = ReoGrid.CurrentWorksheet;

            worksheet["A1"] = "ФИО\\День месяца";
        }

        private void ReoGrid_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillComoBoxMonth()
        {
            for (int i = 0; i < monthNames.Length; i++)
            {
                ComboBoxMonth.Items.Add(monthNames[i]);
            }
        }

        private void ComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private async void FillComboBoxGroups()
        {
            ComboBoxGroup.Items.Clear();

            using (zhirov_cwContext db = new zhirov_cwContext())
            {
                await db.Groups.OrderBy(t => t.GroupsNameAbbreviated).ForEachAsync(t =>
                {
                    ComboBoxGroup.Items.Add(t.GroupsNameAbbreviated);
                });
            }
        }

        private void ComboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
