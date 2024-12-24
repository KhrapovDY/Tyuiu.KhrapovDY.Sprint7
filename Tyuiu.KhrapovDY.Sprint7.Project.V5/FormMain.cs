using System.Data;
using System.Text;
using Tyuiu.KhrapovDY.Sprint7.Project.V5.Lib;
namespace Tyuiu.KhrapovDY.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog_KDY.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.* ";
            saveFileDialog_KDY.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
        }

        string openFilePath;

        DataService ds = new DataService();

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "������� ����";
        }

        private void buttonDone_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "���������";
        }

        private void buttonSaveFile_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "��������� � ����";
        }

        private void buttonHelp_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "�������";
        }

        private void buttonChart_KDY_Click(object sender, EventArgs e)
        {
            FormChart formChart = new FormChart();
            formChart.ShowDialog();

        }

        private void buttonOpenFile_KDY_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "�������� ���� ��� ��������";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string[,] arrayValues = ds.LoadFromFileData(filePath);

                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        dataTable.Columns.Add("��� ������");
                        dataTable.Columns.Add("�������� ������");
                        dataTable.Columns.Add("���������� �� ������");
                        dataTable.Columns.Add("��������� ������� ������");
                        dataTable.Columns.Add("����������");

                        for (int i = 0; i < arrayValues.GetLength(0); i++)
                        {
                            DataRow row = dataTable.NewRow();
                            for (int j = 0; j < arrayValues.GetLength(1); j++)
                            {
                                row[j] = arrayValues[i, j];
                            }
                            dataTable.Rows.Add(row);
                        }
                        dataGridViewOutPut_KDY.DataSource = dataTable;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("������: " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("������ �������: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("��������� ������: " + ex.Message);
                    }
                }
            }
            buttonSaveFile_KDY.Enabled = true;
        }


        private void buttonSaveFile_KDY_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_KDY.FileName = "Outputfile.csv";
                if (saveFileDialog_KDY.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog_KDY.FileName;

                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }
                    int rows = dataGridViewOutPut_KDY.RowCount;
                    int cols = dataGridViewOutPut_KDY.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {

                            string cellVal = dataGridViewOutPut_KDY.Rows[i].Cells[j].Value?.ToString() ?? string.Empty; // �������� �� null �������� ������
                            cellVal = cellVal.Replace("\"", "\"\""); // ������ ������� ������ �������� �� ��� ������� ��� CSV 
                            strBuilder.Append($"\"{cellVal}\""); // ����������� �������� � �������

                            // ��������� ����������� ������ ���� ��� �� ��������� ������� � ������
                            if (j != cols - 1)
                            {
                                strBuilder.Append(","); // ��������� �������� �������  
                            }
                        }
                        strBuilder.AppendLine(); // ����� ������ 
                    }
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("���� ������� �������� �� ��� ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}\n���� �� ��� �������� �� ��� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOutPut_KDY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEdit_KDY_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_KDY.ReadOnly = false;
        }
    }
}