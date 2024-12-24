using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KhrapovDY.Sprint7.Project.V5
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void buttonClose_KDY_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonDoneChart_KDY_Click(object sender, EventArgs e)
        {
            chart_KDY.Series[0].Points.AddXY(Convert.ToDouble(textBoxSum_KDY.Text), Convert.ToDouble(textBoxPrice_KDY.Text));//Эта строка добавляет новую точку на график, который представлен в элементе управления chartDiag_FDK
        }
    }
}
