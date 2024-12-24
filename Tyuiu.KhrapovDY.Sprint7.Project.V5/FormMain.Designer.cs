﻿using Tyuiu.KhrapovDY.Sprint7.Project.V5.Lib;
namespace Tyuiu.KhrapovDY.Sprint7.Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelMenu_KDY = new Panel();
            groupMenu_KDY = new GroupBox();
            textBoxImportFromExcel_KDY = new TextBox();
            buttonImportFromExcel_KDY = new Button();
            buttonSaveFile_KDY = new Button();
            buttonOpenFile_KDY = new Button();
            buttonHelp_KDY = new Button();
            panelControlPanel_KDY = new Panel();
            groupBoxControlPanel_KDY = new GroupBox();
            buttonEdit_KDY = new Button();
            labelInPut_KDY = new Label();
            textBoxInPut_KDY = new TextBox();
            buttonSorting_KDY = new Button();
            buttonFilter_KDY = new Button();
            buttonChart_KDY = new Button();
            openFileDialog_KDY = new OpenFileDialog();
            toolTipButton_KDY = new ToolTip(components);
            saveFileDialog_KDY = new SaveFileDialog();
            panelOutPut_KDY = new Panel();
            groupBoxOutPutData_KDY = new GroupBox();
            dataGridViewOutPut_KDY = new DataGridView();
            panelMenu_KDY.SuspendLayout();
            groupMenu_KDY.SuspendLayout();
            panelControlPanel_KDY.SuspendLayout();
            groupBoxControlPanel_KDY.SuspendLayout();
            panelOutPut_KDY.SuspendLayout();
            groupBoxOutPutData_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KDY).BeginInit();
            SuspendLayout();
            // 
            // panelMenu_KDY
            // 
            panelMenu_KDY.Controls.Add(groupMenu_KDY);
            panelMenu_KDY.Dock = DockStyle.Left;
            panelMenu_KDY.Location = new Point(0, 0);
            panelMenu_KDY.Name = "panelMenu_KDY";
            panelMenu_KDY.Size = new Size(400, 1011);
            panelMenu_KDY.TabIndex = 0;
            // 
            // groupMenu_KDY
            // 
            groupMenu_KDY.BackColor = Color.White;
            groupMenu_KDY.Controls.Add(textBoxImportFromExcel_KDY);
            groupMenu_KDY.Controls.Add(buttonImportFromExcel_KDY);
            groupMenu_KDY.Controls.Add(buttonSaveFile_KDY);
            groupMenu_KDY.Controls.Add(buttonOpenFile_KDY);
            groupMenu_KDY.Controls.Add(buttonHelp_KDY);
            groupMenu_KDY.Dock = DockStyle.Fill;
            groupMenu_KDY.Location = new Point(0, 0);
            groupMenu_KDY.Name = "groupMenu_KDY";
            groupMenu_KDY.Padding = new Padding(5);
            groupMenu_KDY.Size = new Size(400, 1011);
            groupMenu_KDY.TabIndex = 0;
            groupMenu_KDY.TabStop = false;
            groupMenu_KDY.Text = "Главное меню";
            // 
            // textBoxImportFromExcel_KDY
            // 
            textBoxImportFromExcel_KDY.BorderStyle = BorderStyle.FixedSingle;
            textBoxImportFromExcel_KDY.Location = new Point(12, 296);
            textBoxImportFromExcel_KDY.Name = "textBoxImportFromExcel_KDY";
            textBoxImportFromExcel_KDY.ReadOnly = true;
            textBoxImportFromExcel_KDY.Size = new Size(380, 39);
            textBoxImportFromExcel_KDY.TabIndex = 10;
            // 
            // buttonImportFromExcel_KDY
            // 
            buttonImportFromExcel_KDY.Image = (Image)resources.GetObject("buttonImportFromExcel_KDY.Image");
            buttonImportFromExcel_KDY.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportFromExcel_KDY.Location = new Point(12, 216);
            buttonImportFromExcel_KDY.Name = "buttonImportFromExcel_KDY";
            buttonImportFromExcel_KDY.Padding = new Padding(20, 0, 0, 0);
            buttonImportFromExcel_KDY.Size = new Size(382, 74);
            buttonImportFromExcel_KDY.TabIndex = 9;
            buttonImportFromExcel_KDY.Text = "Импорт из Excel";
            toolTipButton_KDY.SetToolTip(buttonImportFromExcel_KDY, "Импортирование файла для обработки данных в формате XLSX\r\n");
            buttonImportFromExcel_KDY.UseVisualStyleBackColor = true;
            buttonImportFromExcel_KDY.Click += buttonImportFromExcel_KDY_Click;
            buttonImportFromExcel_KDY.MouseEnter += buttonImportFromExcel_KDY_MouseEnter;
            // 
            // buttonSaveFile_KDY
            // 
            buttonSaveFile_KDY.Enabled = false;
            buttonSaveFile_KDY.Image = (Image)resources.GetObject("buttonSaveFile_KDY.Image");
            buttonSaveFile_KDY.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveFile_KDY.Location = new Point(12, 126);
            buttonSaveFile_KDY.Name = "buttonSaveFile_KDY";
            buttonSaveFile_KDY.Padding = new Padding(20, 0, 0, 0);
            buttonSaveFile_KDY.Size = new Size(382, 74);
            buttonSaveFile_KDY.TabIndex = 8;
            buttonSaveFile_KDY.Text = "Сохранить файл";
            toolTipButton_KDY.SetToolTip(buttonSaveFile_KDY, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_KDY.UseVisualStyleBackColor = true;
            buttonSaveFile_KDY.Click += buttonSaveFile_KDY_Click;
            buttonSaveFile_KDY.MouseEnter += buttonSaveFile_KDY_MouseEnter;
            // 
            // buttonOpenFile_KDY
            // 
            buttonOpenFile_KDY.Image = (Image)resources.GetObject("buttonOpenFile_KDY.Image");
            buttonOpenFile_KDY.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOpenFile_KDY.Location = new Point(12, 46);
            buttonOpenFile_KDY.Name = "buttonOpenFile_KDY";
            buttonOpenFile_KDY.Padding = new Padding(20, 0, 0, 0);
            buttonOpenFile_KDY.Size = new Size(382, 74);
            buttonOpenFile_KDY.TabIndex = 7;
            buttonOpenFile_KDY.Text = "Открыть файл";
            toolTipButton_KDY.SetToolTip(buttonOpenFile_KDY, "Открыть файл для обработки данных в формате CSV\r\n\r\n");
            buttonOpenFile_KDY.UseVisualStyleBackColor = true;
            buttonOpenFile_KDY.Click += buttonOpenFile_KDY_Click;
            buttonOpenFile_KDY.MouseEnter += buttonOpenFile_KDY_MouseEnter;
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonHelp_KDY.Image = (Image)resources.GetObject("buttonHelp_KDY.Image");
            buttonHelp_KDY.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp_KDY.Location = new Point(14, 923);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Padding = new Padding(20, 0, 0, 0);
            buttonHelp_KDY.Size = new Size(382, 74);
            buttonHelp_KDY.TabIndex = 6;
            buttonHelp_KDY.Text = "Справка";
            toolTipButton_KDY.SetToolTip(buttonHelp_KDY, "Сведение о программе");
            buttonHelp_KDY.UseVisualStyleBackColor = true;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            buttonHelp_KDY.MouseEnter += buttonHelp_KDY_MouseEnter;
            // 
            // panelControlPanel_KDY
            // 
            panelControlPanel_KDY.BackColor = Color.White;
            panelControlPanel_KDY.Controls.Add(groupBoxControlPanel_KDY);
            panelControlPanel_KDY.Dock = DockStyle.Top;
            panelControlPanel_KDY.Location = new Point(400, 0);
            panelControlPanel_KDY.Name = "panelControlPanel_KDY";
            panelControlPanel_KDY.Size = new Size(1614, 136);
            panelControlPanel_KDY.TabIndex = 10;
            // 
            // groupBoxControlPanel_KDY
            // 
            groupBoxControlPanel_KDY.BackColor = Color.White;
            groupBoxControlPanel_KDY.Controls.Add(buttonEdit_KDY);
            groupBoxControlPanel_KDY.Controls.Add(labelInPut_KDY);
            groupBoxControlPanel_KDY.Controls.Add(textBoxInPut_KDY);
            groupBoxControlPanel_KDY.Controls.Add(buttonSorting_KDY);
            groupBoxControlPanel_KDY.Controls.Add(buttonFilter_KDY);
            groupBoxControlPanel_KDY.Controls.Add(buttonChart_KDY);
            groupBoxControlPanel_KDY.Dock = DockStyle.Fill;
            groupBoxControlPanel_KDY.Location = new Point(0, 0);
            groupBoxControlPanel_KDY.Margin = new Padding(5);
            groupBoxControlPanel_KDY.Name = "groupBoxControlPanel_KDY";
            groupBoxControlPanel_KDY.Padding = new Padding(5);
            groupBoxControlPanel_KDY.Size = new Size(1614, 136);
            groupBoxControlPanel_KDY.TabIndex = 0;
            groupBoxControlPanel_KDY.TabStop = false;
            groupBoxControlPanel_KDY.Text = "Панель управления";
            // 
            // buttonEdit_KDY
            // 
            buttonEdit_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit_KDY.Location = new Point(868, 77);
            buttonEdit_KDY.Name = "buttonEdit_KDY";
            buttonEdit_KDY.Size = new Size(208, 46);
            buttonEdit_KDY.TabIndex = 14;
            buttonEdit_KDY.Text = "Редактирование";
            buttonEdit_KDY.UseVisualStyleBackColor = true;
            buttonEdit_KDY.Click += buttonEdit_KDY_Click;
            // 
            // labelInPut_KDY
            // 
            labelInPut_KDY.AutoSize = true;
            labelInPut_KDY.Location = new Point(21, 37);
            labelInPut_KDY.Name = "labelInPut_KDY";
            labelInPut_KDY.Size = new Size(68, 32);
            labelInPut_KDY.TabIndex = 12;
            labelInPut_KDY.Text = "Ввод";
            // 
            // textBoxInPut_KDY
            // 
            textBoxInPut_KDY.BorderStyle = BorderStyle.FixedSingle;
            textBoxInPut_KDY.Location = new Point(21, 81);
            textBoxInPut_KDY.Name = "textBoxInPut_KDY";
            textBoxInPut_KDY.ReadOnly = true;
            textBoxInPut_KDY.Size = new Size(200, 39);
            textBoxInPut_KDY.TabIndex = 11;
            // 
            // buttonSorting_KDY
            // 
            buttonSorting_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSorting_KDY.Location = new Point(1082, 77);
            buttonSorting_KDY.Name = "buttonSorting_KDY";
            buttonSorting_KDY.Size = new Size(191, 46);
            buttonSorting_KDY.TabIndex = 3;
            buttonSorting_KDY.Text = "Сортировка";
            buttonSorting_KDY.UseVisualStyleBackColor = true;
            // 
            // buttonFilter_KDY
            // 
            buttonFilter_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFilter_KDY.Location = new Point(1279, 77);
            buttonFilter_KDY.Name = "buttonFilter_KDY";
            buttonFilter_KDY.Size = new Size(150, 46);
            buttonFilter_KDY.TabIndex = 2;
            buttonFilter_KDY.Text = "Фильтр";
            buttonFilter_KDY.UseVisualStyleBackColor = true;
            // 
            // buttonChart_KDY
            // 
            buttonChart_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonChart_KDY.Location = new Point(1435, 77);
            buttonChart_KDY.Name = "buttonChart_KDY";
            buttonChart_KDY.Size = new Size(167, 46);
            buttonChart_KDY.TabIndex = 1;
            buttonChart_KDY.Text = "Диаграмма";
            buttonChart_KDY.UseVisualStyleBackColor = true;
            buttonChart_KDY.Click += buttonChart_KDY_Click;
            // 
            // openFileDialog_KDY
            // 
            openFileDialog_KDY.FileName = "openFileDialog";
            // 
            // toolTipButton_KDY
            // 
            toolTipButton_KDY.IsBalloon = true;
            // 
            // panelOutPut_KDY
            // 
            panelOutPut_KDY.Controls.Add(groupBoxOutPutData_KDY);
            panelOutPut_KDY.Dock = DockStyle.Fill;
            panelOutPut_KDY.Location = new Point(400, 136);
            panelOutPut_KDY.Name = "panelOutPut_KDY";
            panelOutPut_KDY.Size = new Size(1614, 875);
            panelOutPut_KDY.TabIndex = 13;
            // 
            // groupBoxOutPutData_KDY
            // 
            groupBoxOutPutData_KDY.Controls.Add(dataGridViewOutPut_KDY);
            groupBoxOutPutData_KDY.Dock = DockStyle.Fill;
            groupBoxOutPutData_KDY.Location = new Point(0, 0);
            groupBoxOutPutData_KDY.Name = "groupBoxOutPutData_KDY";
            groupBoxOutPutData_KDY.Padding = new Padding(5);
            groupBoxOutPutData_KDY.Size = new Size(1614, 875);
            groupBoxOutPutData_KDY.TabIndex = 0;
            groupBoxOutPutData_KDY.TabStop = false;
            groupBoxOutPutData_KDY.Text = "Вывод:";
            // 
            // dataGridViewOutPut_KDY
            // 
            dataGridViewOutPut_KDY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_KDY.ColumnHeadersVisible = false;
            dataGridViewOutPut_KDY.Dock = DockStyle.Fill;
            dataGridViewOutPut_KDY.Location = new Point(5, 37);
            dataGridViewOutPut_KDY.Name = "dataGridViewOutPut_KDY";
            dataGridViewOutPut_KDY.ReadOnly = true;
            dataGridViewOutPut_KDY.RowHeadersVisible = false;
            dataGridViewOutPut_KDY.RowHeadersWidth = 82;
            dataGridViewOutPut_KDY.Size = new Size(1604, 833);
            dataGridViewOutPut_KDY.TabIndex = 0;
            dataGridViewOutPut_KDY.CellContentClick += dataGridViewOutPut_KDY_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2014, 1011);
            Controls.Add(panelOutPut_KDY);
            Controls.Add(panelControlPanel_KDY);
            Controls.Add(panelMenu_KDY);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая база";
            panelMenu_KDY.ResumeLayout(false);
            groupMenu_KDY.ResumeLayout(false);
            groupMenu_KDY.PerformLayout();
            panelControlPanel_KDY.ResumeLayout(false);
            groupBoxControlPanel_KDY.ResumeLayout(false);
            groupBoxControlPanel_KDY.PerformLayout();
            panelOutPut_KDY.ResumeLayout(false);
            groupBoxOutPutData_KDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu_KDY;
        private GroupBox groupMenu_KDY;
        private Button buttonSaveFile_KDY;
        private Button buttonOpenFile_KDY;
        private Button buttonHelp_KDY;
        private Panel panelControlPanel_KDY;
        private OpenFileDialog openFileDialog_KDY;
        private ToolTip toolTipButton_KDY;
        private SaveFileDialog saveFileDialog_KDY;
        private GroupBox groupBoxControlPanel_KDY;
        private Button buttonChart_KDY;
        private Panel panelOutPut_KDY;
        private GroupBox groupBoxInPutData_KDY;
        private GroupBox groupBoxOutPutData_KDY;
        private Button buttonSorting_KDY;
        private Button buttonFilter_KDY;
        private DataGridView dataGridViewOutPut_KDY;
        private Label labelInPut_KDY;
        private TextBox textBoxInPut_KDY;
        private Button buttonEdit_KDY;
        private TextBox textBoxImportFromExcel_KDY;
        private Button buttonImportFromExcel_KDY;
    }
}
