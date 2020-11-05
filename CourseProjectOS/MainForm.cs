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

namespace CourseProjectOS
{
    public partial class MainForm : Form
    {
        int CurrentStep { get; set; }

        int IndexOfPageNumClmn { get; set; }

        int IndexOfPageClmn { get; set; }

        Dictionary<int, Step> Steps { get; set; }

        public MainForm()
        {
            InitializeComponent();

            IndexOfPageNumClmn = 0;
            IndexOfPageClmn = 1;
            CurrentStep = 0;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != IndexOfPageClmn)
                return;

            var formattedValue = e.FormattedValue as string;

            if (uint.TryParse(formattedValue, out uint _))
            {
                var gridView = sender as DataGridView;

                gridView[IndexOfPageNumClmn, e.RowIndex].Value = e.RowIndex + 1;
            }
            else if (!string.IsNullOrEmpty(formattedValue))
            {
                e.Cancel = true;
                MessageBox.Show("Введите положительное целочисленное значение!", "Неверный формат данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var gridView = sender as DataGridView;

            for (int i = e.Row.Index; i < gridView.Rows.Count - 1; i++)
            {
                var oldPageNum = (int)gridView[IndexOfPageNumClmn, i].Value;
                gridView[IndexOfPageNumClmn, i].Value = oldPageNum - 1;
            }
        }

        private void ProcessCalculating()
        {
            var memory = new Queue<int>();

            foreach (DataGridViewRow row in startConditionDataGridView.Rows)
            {
                int page = (int)row.Cells[IndexOfPageClmn].Value;
                memory.Enqueue(page);
            }

            for (int i = 0; i < pagesToInsertDataGridView.Rows.Count; i++)
            {
                var pageToInsert = (int)pagesToInsertDataGridView[IndexOfPageClmn, i].Value;
                bool pageFoundInMemory = false;
                var step = new Step
                {
                    OutputString = new Dictionary<string, Color>()
                };

                foreach (int existingPage in memory)
                {
                    if (existingPage == pageToInsert && !pageFoundInMemory)
                    {
                        pageFoundInMemory = true;
                        step.OutputString.Add(existingPage.ToString() + " ", Color.Green);
                    }
                    else
                    {
                        step.OutputString.Add(existingPage.ToString() + " ", Color.Black);
                    }
                }
                bool pageFault = !pageFoundInMemory;
                step.PageFault = pageFault;

                if (pageFault)
                    step.OutputString.Add("<- p", Color.Black);

                Steps.Add(i, step);
            }


        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete && e.KeyCode != Keys.Back)
                return;

            var gridView = sender as DataGridView;
            var selectedRow = gridView.SelectedCells[0].OwningRow;

            gridView.Rows.Remove(selectedRow);
        }
    }

    static class RichTextBoxExtension
    {
        static readonly string NL = Environment.NewLine;
        public static void AppendStep(this RichTextBox richTextBox, Step step)
        {
            foreach (KeyValuePair<string, Color> strWithColor in step.OutputString)
            {
                richTextBox.SelectionColor = strWithColor.Value;
                richTextBox.SelectedText = strWithColor.Key;

                step.NumberOfUndosInRichTextBox++;
            }

            richTextBox.AppendText(NL);
            step.NumberOfUndosInRichTextBox++;
        }

        public static void UndoLastStep(this RichTextBox richTextBox, Step step)
        {
            for (int i = 0; i < step.NumberOfUndosInRichTextBox; i++)
                richTextBox.Undo();
        }
    }
}