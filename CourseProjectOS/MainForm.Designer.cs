namespace CourseProjectOS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.startConditionDataGridView = new System.Windows.Forms.DataGridView();
            this.pageNumClmnStartDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageClmnStartDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pagesToInsertDataGridView = new System.Windows.Forms.DataGridView();
            this.pageNumClmnInsrtDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageClmnInsrtDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.algorithmRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startConditionDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesToInsertDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.startConditionDataGridView);
            this.groupBox.Location = new System.Drawing.Point(299, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(485, 610);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Начальное состояние";
            // 
            // startConditionDataGridView
            // 
            this.startConditionDataGridView.AllowUserToResizeColumns = false;
            this.startConditionDataGridView.AllowUserToResizeRows = false;
            this.startConditionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.startConditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.startConditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pageNumClmnStartDGV,
            this.pageClmnStartDGV});
            this.startConditionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startConditionDataGridView.Location = new System.Drawing.Point(3, 22);
            this.startConditionDataGridView.MultiSelect = false;
            this.startConditionDataGridView.Name = "startConditionDataGridView";
            this.startConditionDataGridView.RowHeadersVisible = false;
            this.startConditionDataGridView.RowHeadersWidth = 62;
            this.startConditionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.startConditionDataGridView.RowTemplate.Height = 28;
            this.startConditionDataGridView.Size = new System.Drawing.Size(479, 585);
            this.startConditionDataGridView.TabIndex = 0;
            this.startConditionDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView_CellValidating);
            this.startConditionDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridView_UserDeletingRow);
            this.startConditionDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // pageNumClmnStartDGV
            // 
            this.pageNumClmnStartDGV.HeaderText = "Номер страницы";
            this.pageNumClmnStartDGV.MinimumWidth = 8;
            this.pageNumClmnStartDGV.Name = "pageNumClmnStartDGV";
            this.pageNumClmnStartDGV.ReadOnly = true;
            this.pageNumClmnStartDGV.Width = 80;
            // 
            // pageClmnStartDGV
            // 
            this.pageClmnStartDGV.HeaderText = "Страница";
            this.pageClmnStartDGV.MinimumWidth = 8;
            this.pageClmnStartDGV.Name = "pageClmnStartDGV";
            this.pageClmnStartDGV.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pagesToInsertDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(790, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 610);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Страницы для вставки";
            // 
            // pagesToInsertDataGridView
            // 
            this.pagesToInsertDataGridView.AllowUserToResizeColumns = false;
            this.pagesToInsertDataGridView.AllowUserToResizeRows = false;
            this.pagesToInsertDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pagesToInsertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagesToInsertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pageNumClmnInsrtDGV,
            this.pageClmnInsrtDGV});
            this.pagesToInsertDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesToInsertDataGridView.Location = new System.Drawing.Point(3, 22);
            this.pagesToInsertDataGridView.MultiSelect = false;
            this.pagesToInsertDataGridView.Name = "pagesToInsertDataGridView";
            this.pagesToInsertDataGridView.RowHeadersVisible = false;
            this.pagesToInsertDataGridView.RowHeadersWidth = 62;
            this.pagesToInsertDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pagesToInsertDataGridView.RowTemplate.Height = 28;
            this.pagesToInsertDataGridView.Size = new System.Drawing.Size(479, 585);
            this.pagesToInsertDataGridView.TabIndex = 0;
            this.pagesToInsertDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView_CellValidating);
            this.pagesToInsertDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridView_UserDeletingRow);
            // 
            // pageNumClmnInsrtDGV
            // 
            this.pageNumClmnInsrtDGV.HeaderText = "Номер страницы";
            this.pageNumClmnInsrtDGV.MinimumWidth = 8;
            this.pageNumClmnInsrtDGV.Name = "pageNumClmnInsrtDGV";
            this.pageNumClmnInsrtDGV.ReadOnly = true;
            this.pageNumClmnInsrtDGV.Width = 80;
            // 
            // pageClmnInsrtDGV
            // 
            this.pageClmnInsrtDGV.HeaderText = "Страница";
            this.pageClmnInsrtDGV.MinimumWidth = 8;
            this.pageClmnInsrtDGV.Name = "pageClmnInsrtDGV";
            this.pageClmnInsrtDGV.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.algorithmRichTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 610);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ход алгоритма";
            // 
            // algorithmRichTextBox
            // 
            this.algorithmRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmRichTextBox.Location = new System.Drawing.Point(3, 22);
            this.algorithmRichTextBox.Name = "algorithmRichTextBox";
            this.algorithmRichTextBox.ReadOnly = true;
            this.algorithmRichTextBox.Size = new System.Drawing.Size(275, 585);
            this.algorithmRichTextBox.TabIndex = 0;
            this.algorithmRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Name = "MainForm";
            this.Text = "Симуляция алгоритма FIFO";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startConditionDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagesToInsertDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView startConditionDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pagesToInsertDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox algorithmRichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumClmnInsrtDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageClmnInsrtDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumClmnStartDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageClmnStartDGV;
    }
}

