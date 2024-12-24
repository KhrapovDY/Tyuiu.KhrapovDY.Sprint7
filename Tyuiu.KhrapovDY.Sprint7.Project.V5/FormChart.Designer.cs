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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelLeft_KDY = new Panel();
            groupBoxButtons_KDY = new GroupBox();
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
            // buttonDoneChart_KDY
            // 
            buttonDoneChart_KDY.Location = new Point(12, 38);
            buttonDoneChart_KDY.Name = "buttonDoneChart_KDY";
            buttonDoneChart_KDY.Size = new Size(291, 77);
            buttonDoneChart_KDY.TabIndex = 1;
            buttonDoneChart_KDY.Text = "Выполнить";
            buttonDoneChart_KDY.UseVisualStyleBackColor = true;
            // 
            // buttonClose_KDY
            // 
            buttonClose_KDY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClose_KDY.Location = new Point(12, 703);
            buttonClose_KDY.Name = "buttonClose_KDY";
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
            chart_KDY.Text = "chart1";
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
    }
}