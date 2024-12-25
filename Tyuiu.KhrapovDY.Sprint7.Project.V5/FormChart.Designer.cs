namespace Tyuiu.KhrapovDY.Sprint7.Project.V5
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelLeft_KDY = new Panel();
            groupBoxButtons_KDY = new GroupBox();
            labelPrice_KDY = new Label();
            labelSum_KDY = new Label();
            textBoxPrice_KDY = new TextBox();
            textBoxSum_KDY = new TextBox();
            buttonDoneChart_KDY = new Button();
            buttonClose_KDY = new Button();
            panelTop_KDY = new Panel();
            groupBoxChart_KDY = new GroupBox();
            chart_KDY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelLeft_KDY.SuspendLayout();
            groupBoxButtons_KDY.SuspendLayout();
            panelTop_KDY.SuspendLayout();
            groupBoxChart_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_KDY).BeginInit();
            SuspendLayout();
            // 
            // panelLeft_KDY
            // 
            panelLeft_KDY.Controls.Add(groupBoxButtons_KDY);
            panelLeft_KDY.Dock = DockStyle.Left;
            panelLeft_KDY.Location = new Point(0, 0);
            panelLeft_KDY.Name = "panelLeft_KDY";
            panelLeft_KDY.Size = new Size(309, 792);
            panelLeft_KDY.TabIndex = 0;
            // 
            // groupBoxButtons_KDY
            // 
            groupBoxButtons_KDY.Controls.Add(labelPrice_KDY);
            groupBoxButtons_KDY.Controls.Add(labelSum_KDY);
            groupBoxButtons_KDY.Controls.Add(textBoxPrice_KDY);
            groupBoxButtons_KDY.Controls.Add(textBoxSum_KDY);
            groupBoxButtons_KDY.Controls.Add(buttonDoneChart_KDY);
            groupBoxButtons_KDY.Controls.Add(buttonClose_KDY);
            groupBoxButtons_KDY.Dock = DockStyle.Fill;
            groupBoxButtons_KDY.Location = new Point(0, 0);
            groupBoxButtons_KDY.Name = "groupBoxButtons_KDY";
            groupBoxButtons_KDY.Size = new Size(309, 792);
            groupBoxButtons_KDY.TabIndex = 0;
            groupBoxButtons_KDY.TabStop = false;
            groupBoxButtons_KDY.Text = "Панель управления:";
            // 
            // labelPrice_KDY
            // 
            labelPrice_KDY.AutoSize = true;
            labelPrice_KDY.Location = new Point(12, 309);
            labelPrice_KDY.Name = "labelPrice_KDY";
            labelPrice_KDY.Size = new Size(213, 32);
            labelPrice_KDY.TabIndex = 5;
            labelPrice_KDY.Text = "Стоимость товара";
            // 
            // labelSum_KDY
            // 
            labelSum_KDY.AutoSize = true;
            labelSum_KDY.Location = new Point(12, 181);
            labelSum_KDY.Name = "labelSum_KDY";
            labelSum_KDY.Size = new Size(226, 32);
            labelSum_KDY.TabIndex = 4;
            labelSum_KDY.Text = "Количество товара";
            // 
            // textBoxPrice_KDY
            // 
            textBoxPrice_KDY.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice_KDY.Location = new Point(12, 344);
            textBoxPrice_KDY.Name = "textBoxPrice_KDY";
            textBoxPrice_KDY.Size = new Size(291, 39);
            textBoxPrice_KDY.TabIndex = 3;
            // 
            // textBoxSum_KDY
            // 
            textBoxSum_KDY.BorderStyle = BorderStyle.FixedSingle;
            textBoxSum_KDY.Location = new Point(12, 216);
            textBoxSum_KDY.Name = "textBoxSum_KDY";
            textBoxSum_KDY.Size = new Size(291, 39);
            textBoxSum_KDY.TabIndex = 2;
            // 
            // buttonDoneChart_KDY
            // 
            buttonDoneChart_KDY.Image = (Image)resources.GetObject("buttonDoneChart_KDY.Image");
            buttonDoneChart_KDY.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDoneChart_KDY.Location = new Point(12, 38);
            buttonDoneChart_KDY.Name = "buttonDoneChart_KDY";
            buttonDoneChart_KDY.Padding = new Padding(20, 0, 0, 0);
            buttonDoneChart_KDY.Size = new Size(291, 77);
            buttonDoneChart_KDY.TabIndex = 1;
            buttonDoneChart_KDY.Text = "Выполнить";
            buttonDoneChart_KDY.UseVisualStyleBackColor = true;
            buttonDoneChart_KDY.Click += buttonDoneChart_KDY_Click;
            // 
            // buttonClose_KDY
            // 
            buttonClose_KDY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClose_KDY.Image = (Image)resources.GetObject("buttonClose_KDY.Image");
            buttonClose_KDY.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose_KDY.Location = new Point(12, 703);
            buttonClose_KDY.Name = "buttonClose_KDY";
            buttonClose_KDY.Padding = new Padding(20, 0, 0, 0);
            buttonClose_KDY.Size = new Size(291, 77);
            buttonClose_KDY.TabIndex = 0;
            buttonClose_KDY.Text = "Закрыть";
            buttonClose_KDY.UseVisualStyleBackColor = true;
            buttonClose_KDY.Click += buttonClose_KDY_Click;
            // 
            // panelTop_KDY
            // 
            panelTop_KDY.Controls.Add(groupBoxChart_KDY);
            panelTop_KDY.Dock = DockStyle.Fill;
            panelTop_KDY.Location = new Point(309, 0);
            panelTop_KDY.Name = "panelTop_KDY";
            panelTop_KDY.Size = new Size(1418, 792);
            panelTop_KDY.TabIndex = 0;
            // 
            // groupBoxChart_KDY
            // 
            groupBoxChart_KDY.Controls.Add(chart_KDY);
            groupBoxChart_KDY.Dock = DockStyle.Fill;
            groupBoxChart_KDY.Location = new Point(0, 0);
            groupBoxChart_KDY.Name = "groupBoxChart_KDY";
            groupBoxChart_KDY.Size = new Size(1418, 792);
            groupBoxChart_KDY.TabIndex = 0;
            groupBoxChart_KDY.TabStop = false;
            groupBoxChart_KDY.Text = "Диаграмма:";
            // 
            // chart_KDY
            // 
            chartArea1.Name = "ChartArea1";
            chart_KDY.ChartAreas.Add(chartArea1);
            chart_KDY.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_KDY.Legends.Add(legend1);
            chart_KDY.Location = new Point(3, 35);
            chart_KDY.Name = "chart_KDY";
            chart_KDY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_KDY.Series.Add(series1);
            chart_KDY.Size = new Size(1412, 754);
            chart_KDY.TabIndex = 0;
            chart_KDY.Text = "chart";
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1727, 792);
            Controls.Add(panelTop_KDY);
            Controls.Add(panelLeft_KDY);
            Name = "FormChart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChart";
            panelLeft_KDY.ResumeLayout(false);
            groupBoxButtons_KDY.ResumeLayout(false);
            groupBoxButtons_KDY.PerformLayout();
            panelTop_KDY.ResumeLayout(false);
            groupBoxChart_KDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft_KDY;
        private GroupBox groupBoxButtons_KDY;
        private Panel panelTop_KDY;
        private GroupBox groupBoxChart_KDY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KDY;
        private Button buttonDoneChart_KDY;
        private Button buttonClose_KDY;
        private Label labelPrice_KDY;
        private Label labelSum_KDY;
        private TextBox textBoxPrice_KDY;
        private TextBox textBoxSum_KDY;
    }
}