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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startConditionDataGridView = new System.Windows.Forms.DataGridView();
            this.pageClmnStartDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageNumClmnStartDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pagesToInsertDataGridView = new System.Windows.Forms.DataGridView();
            this.pageClmnInsrtDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageNumClmnInsrtDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextStepButt = new System.Windows.Forms.Button();
            this.undoButt = new System.Windows.Forms.Button();
            this.executeButt = new System.Windows.Forms.Button();
            this.resetButt = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.algorithmStepsPanel = new System.Windows.Forms.Panel();
            this.randButt = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataAndResultMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButt = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramButt = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startConditionDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesToInsertDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.startConditionDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(290, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальное состояние";
            // 
            // startConditionDataGridView
            // 
            this.startConditionDataGridView.AllowUserToResizeColumns = false;
            this.startConditionDataGridView.AllowUserToResizeRows = false;
            this.startConditionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.startConditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.startConditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pageClmnStartDGV,
            this.pageNumClmnStartDGV});
            this.startConditionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startConditionDataGridView.Location = new System.Drawing.Point(3, 22);
            this.startConditionDataGridView.MultiSelect = false;
            this.startConditionDataGridView.Name = "startConditionDataGridView";
            this.startConditionDataGridView.RowHeadersVisible = false;
            this.startConditionDataGridView.RowHeadersWidth = 62;
            this.startConditionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.startConditionDataGridView.RowTemplate.Height = 28;
            this.startConditionDataGridView.Size = new System.Drawing.Size(479, 486);
            this.startConditionDataGridView.TabIndex = 0;
            this.startConditionDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridViewCellValidating);
            this.startConditionDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridViewUserDeletingRow);
            this.startConditionDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewKeyDown);
            // 
            // pageClmnStartDGV
            // 
            this.pageClmnStartDGV.HeaderText = "Страница";
            this.pageClmnStartDGV.MinimumWidth = 8;
            this.pageClmnStartDGV.Name = "pageClmnStartDGV";
            this.pageClmnStartDGV.Width = 80;
            // 
            // pageNumClmnStartDGV
            // 
            this.pageNumClmnStartDGV.HeaderText = "Номер страницы";
            this.pageNumClmnStartDGV.MinimumWidth = 8;
            this.pageNumClmnStartDGV.Name = "pageNumClmnStartDGV";
            this.pageNumClmnStartDGV.ReadOnly = true;
            this.pageNumClmnStartDGV.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pagesToInsertDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(781, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Страницы для вставки";
            // 
            // pagesToInsertDataGridView
            // 
            this.pagesToInsertDataGridView.AllowUserToResizeColumns = false;
            this.pagesToInsertDataGridView.AllowUserToResizeRows = false;
            this.pagesToInsertDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pagesToInsertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagesToInsertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pageClmnInsrtDGV,
            this.pageNumClmnInsrtDGV});
            this.pagesToInsertDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesToInsertDataGridView.Location = new System.Drawing.Point(3, 22);
            this.pagesToInsertDataGridView.MultiSelect = false;
            this.pagesToInsertDataGridView.Name = "pagesToInsertDataGridView";
            this.pagesToInsertDataGridView.RowHeadersVisible = false;
            this.pagesToInsertDataGridView.RowHeadersWidth = 62;
            this.pagesToInsertDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pagesToInsertDataGridView.RowTemplate.Height = 28;
            this.pagesToInsertDataGridView.Size = new System.Drawing.Size(479, 486);
            this.pagesToInsertDataGridView.TabIndex = 0;
            this.pagesToInsertDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridViewCellValidating);
            this.pagesToInsertDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridViewUserDeletingRow);
            this.pagesToInsertDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewKeyDown);
            // 
            // pageClmnInsrtDGV
            // 
            this.pageClmnInsrtDGV.HeaderText = "Страница";
            this.pageClmnInsrtDGV.MinimumWidth = 8;
            this.pageClmnInsrtDGV.Name = "pageClmnInsrtDGV";
            this.pageClmnInsrtDGV.Width = 80;
            // 
            // pageNumClmnInsrtDGV
            // 
            this.pageNumClmnInsrtDGV.HeaderText = "Номер страницы";
            this.pageNumClmnInsrtDGV.MinimumWidth = 8;
            this.pageNumClmnInsrtDGV.Name = "pageNumClmnInsrtDGV";
            this.pageNumClmnInsrtDGV.ReadOnly = true;
            this.pageNumClmnInsrtDGV.Width = 80;
            // 
            // nextStepButt
            // 
            this.nextStepButt.Enabled = false;
            this.nextStepButt.Location = new System.Drawing.Point(124, 36);
            this.nextStepButt.Name = "nextStepButt";
            this.nextStepButt.Size = new System.Drawing.Size(115, 69);
            this.nextStepButt.TabIndex = 3;
            this.nextStepButt.Text = "Следующий шаг";
            this.nextStepButt.UseVisualStyleBackColor = true;
            this.nextStepButt.Click += new System.EventHandler(this.NextStepButtClick);
            // 
            // undoButt
            // 
            this.undoButt.Enabled = false;
            this.undoButt.Location = new System.Drawing.Point(3, 36);
            this.undoButt.Name = "undoButt";
            this.undoButt.Size = new System.Drawing.Size(115, 69);
            this.undoButt.TabIndex = 4;
            this.undoButt.Text = "Назад";
            this.undoButt.UseVisualStyleBackColor = true;
            this.undoButt.Click += new System.EventHandler(this.UndoButtClick);
            // 
            // executeButt
            // 
            this.executeButt.Enabled = false;
            this.executeButt.Location = new System.Drawing.Point(245, 36);
            this.executeButt.Name = "executeButt";
            this.executeButt.Size = new System.Drawing.Size(115, 69);
            this.executeButt.TabIndex = 6;
            this.executeButt.Text = "Выполнить";
            this.executeButt.UseVisualStyleBackColor = true;
            this.executeButt.Click += new System.EventHandler(this.ExecuteButtClick);
            // 
            // resetButt
            // 
            this.resetButt.Enabled = false;
            this.resetButt.Location = new System.Drawing.Point(781, 36);
            this.resetButt.Name = "resetButt";
            this.resetButt.Size = new System.Drawing.Size(115, 69);
            this.resetButt.TabIndex = 5;
            this.resetButt.Text = "Сброс";
            this.resetButt.UseVisualStyleBackColor = true;
            this.resetButt.Click += new System.EventHandler(this.ResetButtClick);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.algorithmStepsPanel);
            this.groupBox.Location = new System.Drawing.Point(3, 111);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(281, 511);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ход алгоритма";
            // 
            // algorithmStepsPanel
            // 
            this.algorithmStepsPanel.AutoScroll = true;
            this.algorithmStepsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmStepsPanel.Location = new System.Drawing.Point(3, 22);
            this.algorithmStepsPanel.Name = "algorithmStepsPanel";
            this.algorithmStepsPanel.Size = new System.Drawing.Size(275, 486);
            this.algorithmStepsPanel.TabIndex = 0;
            // 
            // randButt
            // 
            this.randButt.Location = new System.Drawing.Point(660, 36);
            this.randButt.Name = "randButt";
            this.randButt.Size = new System.Drawing.Size(115, 69);
            this.randButt.TabIndex = 7;
            this.randButt.Text = "Заполнить случайно";
            this.randButt.UseVisualStyleBackColor = true;
            this.randButt.Click += new System.EventHandler(this.RandButtClick);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStripItem,
            this.aboutProgramButt});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1314, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuStripItem
            // 
            this.fileMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMenuStripItem,
            this.exportDataMenuStripItem,
            this.exportDataAndResultMenuStripItem,
            this.exitButt});
            this.fileMenuStripItem.Name = "fileMenuStripItem";
            this.fileMenuStripItem.Size = new System.Drawing.Size(69, 29);
            this.fileMenuStripItem.Text = "Файл";
            // 
            // importMenuStripItem
            // 
            this.importMenuStripItem.Name = "importMenuStripItem";
            this.importMenuStripItem.Size = new System.Drawing.Size(423, 34);
            this.importMenuStripItem.Text = "Импорт из excel...";
            this.importMenuStripItem.Click += new System.EventHandler(this.ImportMenuStripItemClick);
            // 
            // exportDataMenuStripItem
            // 
            this.exportDataMenuStripItem.Name = "exportDataMenuStripItem";
            this.exportDataMenuStripItem.Size = new System.Drawing.Size(423, 34);
            this.exportDataMenuStripItem.Text = "Экспорт данных в excel...";
            this.exportDataMenuStripItem.Click += new System.EventHandler(this.ExportDataMenuStripItemClick);
            // 
            // exportDataAndResultMenuStripItem
            // 
            this.exportDataAndResultMenuStripItem.Name = "exportDataAndResultMenuStripItem";
            this.exportDataAndResultMenuStripItem.Size = new System.Drawing.Size(423, 34);
            this.exportDataAndResultMenuStripItem.Text = "Экспорт данных и результата в excel...";
            this.exportDataAndResultMenuStripItem.Click += new System.EventHandler(this.ExportDataAndResultMenuStripItemClick);
            // 
            // exitButt
            // 
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(423, 34);
            this.exitButt.Text = "Выход";
            this.exitButt.Click += new System.EventHandler(this.ExitButtClick);
            // 
            // aboutProgramButt
            // 
            this.aboutProgramButt.Name = "aboutProgramButt";
            this.aboutProgramButt.Size = new System.Drawing.Size(153, 29);
            this.aboutProgramButt.Text = "О программе...";
            this.aboutProgramButt.Click += new System.EventHandler(this.AboutProgramButtClick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel files|*.xlsx";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel files|*.xlsx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 634);
            this.Controls.Add(this.randButt);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.executeButt);
            this.Controls.Add(this.resetButt);
            this.Controls.Add(this.undoButt);
            this.Controls.Add(this.nextStepButt);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Визуализация алгоритма FIFO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startConditionDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagesToInsertDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView startConditionDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView pagesToInsertDataGridView;
        private System.Windows.Forms.Button nextStepButt;
        private System.Windows.Forms.Button undoButt;
        private System.Windows.Forms.Button executeButt;
        private System.Windows.Forms.Button resetButt;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel algorithmStepsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageClmnStartDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumClmnStartDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageClmnInsrtDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumClmnInsrtDGV;
        private System.Windows.Forms.Button randButt;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem importMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataAndResultMenuStripItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitButt;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramButt;
    }
}

