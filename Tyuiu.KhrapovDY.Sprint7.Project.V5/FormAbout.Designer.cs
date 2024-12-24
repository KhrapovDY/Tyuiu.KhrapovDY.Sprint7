namespace Tyuiu.KhrapovDY.Sprint7.Project.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxInfo_KDY = new PictureBox();
            labelInfo_KDY = new Label();
            buttonOK_KDY = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_KDY).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxInfo_KDY
            // 
            pictureBoxInfo_KDY.Image = (Image)resources.GetObject("pictureBoxInfo_KDY.Image");
            pictureBoxInfo_KDY.Location = new Point(34, 37);
            pictureBoxInfo_KDY.Name = "pictureBoxInfo_KDY";
            pictureBoxInfo_KDY.Size = new Size(216, 218);
            pictureBoxInfo_KDY.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxInfo_KDY.TabIndex = 0;
            pictureBoxInfo_KDY.TabStop = false;
            // 
            // labelInfo_KDY
            // 
            labelInfo_KDY.Location = new Point(267, 37);
            labelInfo_KDY.Name = "labelInfo_KDY";
            labelInfo_KDY.Size = new Size(629, 301);
            labelInfo_KDY.TabIndex = 1;
            labelInfo_KDY.Text = resources.GetString("labelInfo_KDY.Text");
            // 
            // buttonOK_KDY
            // 
            buttonOK_KDY.Location = new Point(725, 341);
            buttonOK_KDY.Name = "buttonOK_KDY";
            buttonOK_KDY.Size = new Size(150, 46);
            buttonOK_KDY.TabIndex = 2;
            buttonOK_KDY.Text = "OK";
            buttonOK_KDY.UseVisualStyleBackColor = true;
            buttonOK_KDY.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 409);
            Controls.Add(buttonOK_KDY);
            Controls.Add(labelInfo_KDY);
            Controls.Add(pictureBoxInfo_KDY);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxInfo_KDY;
        private Label labelInfo_KDY;
        private Button buttonOK_KDY;
    }
}