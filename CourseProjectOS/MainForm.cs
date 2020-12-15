using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using ClosedXML.Excel;

namespace CourseProjectOS
{
    public partial class MainForm : Form
    {
        int CurrentStep { get; set; }

        bool CalculationCompleted { get; set; }

        int IndexOfPageNumClmn { get; set; }

        int IndexOfPageClmn { get; set; }

        List<RichTextBox> Steps { get; set; } = new List<RichTextBox>();

        Random RandomNumGenerator { get; set; } = new Random();

        public MainForm()
        {
            InitializeComponent();

            IndexOfPageNumClmn = 1;
            IndexOfPageClmn = 0;
            CurrentStep = 0;
        }

        private void GridViewsEnabled(bool enabled)
        {
            startConditionDataGridView.Enabled = enabled;
            pagesToInsertDataGridView.Enabled = enabled;
        }

        private void CheckAndEnableButts()
        {
            if (startConditionDataGridView.Rows.Count != 1 && pagesToInsertDataGridView.Rows.Count != 1)
            {
                nextStepButt.Enabled = true;
                executeButt.Enabled = true;
                resetButt.Enabled = true;
            }
            else
            {
                nextStepButt.Enabled = false;
                executeButt.Enabled = false;
                resetButt.Enabled = false;
            }
        }

        private void DataGridViewCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != IndexOfPageClmn)
                return;

            var formattedValue = e.FormattedValue.ToString();

            if (uint.TryParse(formattedValue, out uint _))
            {
                var gridView = sender as DataGridView;

                gridView[IndexOfPageNumClmn, e.RowIndex].Value = e.RowIndex + 1;

                CheckAndEnableButts();
            }
            else if (!string.IsNullOrEmpty(formattedValue))
            {
                e.Cancel = true;
                MessageBox.Show("Введите положительное целочисленное значение!", "Неверный формат данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var gridView = sender as DataGridView;

            for (int i = e.Row.Index; i < gridView.Rows.Count - 1; i++)
            {
                var oldPageNum = int.Parse(gridView[IndexOfPageNumClmn, i].Value.ToString());
                gridView[IndexOfPageNumClmn, i].Value = oldPageNum - 1;
            }

            CheckAndEnableButts();
        }

        private void ProcessCalculating()
        {
            var memory = new Queue<int>();

            for (int i = 0; i < startConditionDataGridView.Rows.Count - 1; i++)
            {
                int page = int.Parse(startConditionDataGridView[IndexOfPageClmn, i].Value.ToString());
                memory.Enqueue(page);
            }

            string startCondition = string.Join(" ", memory);
            var startConditionTextBox = new RichTextBox
            {
                Text = startCondition,
                Size = new Size(265, 30),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Dock = DockStyle.Top,
                ReadOnly = true
            };
            startConditionTextBox.ContentsResized += ResizeRichTextBox;
            Steps.Add(startConditionTextBox);

            for (int i = 0; i < pagesToInsertDataGridView.Rows.Count - 1; i++)
            {
                var pageToInsert = int.Parse(pagesToInsertDataGridView[IndexOfPageClmn, i].Value.ToString());
                bool pageFoundInMemory = false;

                var stepTextBox = new RichTextBox
                {
                    Size = new Size(265, 30),
                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    ReadOnly = true
                };
                stepTextBox.ContentsResized += ResizeRichTextBox;

                stepTextBox.SelectedText = (i + 1) + ". ";

                Color color;
                foreach (int existingPage in memory)
                {
                    if (existingPage == pageToInsert && !pageFoundInMemory)
                    {
                        pageFoundInMemory = true;
                        color = Color.Green;
                    }
                    else
                    {
                        color = Color.Black;
                    }

                    stepTextBox.SelectionColor = color;
                    stepTextBox.SelectedText = existingPage + " ";
                }

                stepTextBox.SelectionColor = Color.Black;
                stepTextBox.SelectedText = "<- " + pageToInsert;

                if (!pageFoundInMemory)
                {
                    stepTextBox.Select(((i + 1) + ". ").Length, memory.Peek().ToString().Length);
                    stepTextBox.SelectionColor = Color.Red;
                    stepTextBox.Select(stepTextBox.Text.Length, 0);
                    stepTextBox.SelectionColor = Color.Red;
                    stepTextBox.SelectedText = " p";

                    memory.Dequeue();
                    memory.Enqueue(pageToInsert);
                }

                Steps.Add(stepTextBox);
            }

            CalculationCompleted = true;
        }

        private void ResizeRichTextBox(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }

        private void DataGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete && e.KeyCode != Keys.Back)
                return;

            var gridView = sender as DataGridView;
            var selectedRow = gridView.SelectedCells[0].OwningRow;

            if (!selectedRow.IsNewRow)
            {
                gridView.Rows.Remove(selectedRow);
                CheckAndEnableButts();
            }
        }

        private void NextStepButtClick(object sender, EventArgs e)
        {
            GridViewsEnabled(false);
            undoButt.Enabled = true;

            if (!CalculationCompleted)
                ProcessCalculating();

            algorithmStepsPanel.Controls.Add(Steps[CurrentStep++]);

            if (CurrentStep == Steps.Count)
            {
                executeButt.Enabled = false;
                nextStepButt.Enabled = false;
                resetButt.Enabled = true;
            }
        }

        private void UndoButtClick(object sender, EventArgs e)
        {
            nextStepButt.Enabled = true;
            executeButt.Enabled = true;
            algorithmStepsPanel.Controls.Remove(Steps[--CurrentStep]);

            if (CurrentStep == 0)
            {
                undoButt.Enabled = false;
                resetButt.Enabled = true;
                GridViewsEnabled(true);
            }
        }

        private void ResetButtClick(object sender, EventArgs e)
        {
            resetButt.Enabled = false;
            undoButt.Enabled = false;
            nextStepButt.Enabled = false;
            executeButt.Enabled = false;

            startConditionDataGridView.Rows.Clear();
            pagesToInsertDataGridView.Rows.Clear();
            startConditionDataGridView.Enabled = true;
            pagesToInsertDataGridView.Enabled = true;

            Steps.Clear();
            algorithmStepsPanel.Controls.Clear();

            algorithmStepsPanel.Controls.Clear();

            CurrentStep = 0;

            CalculationCompleted = false;
        }

        private void ExecuteButtClick(object sender, EventArgs e)
        {
            while (executeButt.Enabled)
                NextStepButtClick(sender, e);
        }

        private void RandButtClick(object sender, EventArgs e)
        {
            ResetButtClick(sender, e);
            for (int i = 0; i < 5; i++)
                startConditionDataGridView.Rows.Add(RandomNumGenerator.Next(0, 16).ToString(), i + 1);

            for (int i = 0; i < 16; i++)
                pagesToInsertDataGridView.Rows.Add(RandomNumGenerator.Next(0, 16).ToString(), i + 1);

            CheckAndEnableButts();
        }

        private void ImportMenuStripItemClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ResetButtClick(null, null);

                using (var wb = new XLWorkbook(openFileDialog.FileName))
                {
                    IXLWorksheet ws = wb.Worksheets.First();
                    for (int i = 0; ; i++)
                    {
                        try
                        {
                            startConditionDataGridView.Rows.Add(int.Parse(ws.Cell(i + 1, 1).Value.ToString()),
                                int.Parse(ws.Cell(i + 1, 2).Value.ToString()));
                        }
                        catch
                        {
                            break;
                        }
                    }

                    for (int i = 0; ; i++)
                    {
                        try
                        {
                            pagesToInsertDataGridView.Rows.Add(int.Parse(ws.Cell(i + 1, 3).Value.ToString()),
                                int.Parse(ws.Cell(i + 1, 4).Value.ToString()));
                        }
                        catch
                        {
                            break;
                        }
                    }
                }
            }
            CheckAndEnableButts();
        }

        private void ExportDataMenuStripItemClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataFunc();
                MessageBox.Show("Данные сохранены.");
            }
        }

        private void ExportDataAndResultMenuStripItemClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!CalculationCompleted)
                    ProcessCalculating();

                int lastModifiedCell = ExportDataFunc();

                using (var wb = new XLWorkbook(saveFileDialog.FileName))
                {
                    IXLWorksheet ws = wb.Worksheets.First();

                    lastModifiedCell++;
                    ws.Cell(lastModifiedCell, 1).Value = "Ход алгоритма";
                    lastModifiedCell++;

                    for (int i = 0; i < Steps.Count; i++)
                    {
                        ws.Cell(lastModifiedCell + i, 1).Value = Steps[i].Text;
                    }

                    wb.Save();
                }

                MessageBox.Show("Данные сохранены.");
            }
        }

        private int ExportDataFunc()
        {
            if (startConditionDataGridView.RowCount == 1 || pagesToInsertDataGridView.RowCount == 1)
            {
                MessageBox.Show("Таблицы пусты, экспортировать нечего.");
                return 0;
            }

            int lastModifiedCell;

            using (var wb = new XLWorkbook())
            {
                IXLWorksheet ws = wb.AddWorksheet();

                for (int i = 1; i < startConditionDataGridView.RowCount; i++)
                {
                    ws.Cell(i, 1).Value = startConditionDataGridView[0, i - 1].Value;
                    ws.Cell(i, 2).Value = startConditionDataGridView[1, i - 1].Value;
                }

                for (int i = 1; i < pagesToInsertDataGridView.RowCount; i++)
                {
                    ws.Cell(i, 3).Value = pagesToInsertDataGridView[0, i - 1].Value;
                    ws.Cell(i, 4).Value = pagesToInsertDataGridView[1, i - 1].Value;
                }
                lastModifiedCell = Math.Max(startConditionDataGridView.RowCount, pagesToInsertDataGridView.RowCount);
                wb.SaveAs(saveFileDialog.FileName);
            }

            return lastModifiedCell;
        }

        private void ExitButtClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutProgramButtClick(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }
    }
}