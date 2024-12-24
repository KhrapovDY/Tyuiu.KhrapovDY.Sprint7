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

            openFileDialog_KDY.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.* ";
            saveFileDialog_KDY.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
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
            toolTipButton_KDY.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KDY_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDY.ToolTipTitle = "Справка";
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
                openFileDialog.Title = "Выберите файл для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string[,] arrayValues = ds.LoadFromFileData(filePath);

                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        dataTable.Columns.Add("Код товара");
                        dataTable.Columns.Add("Название товара");
                        dataTable.Columns.Add("Количество на складе");
                        dataTable.Columns.Add("Стоимость единицы товара");
                        dataTable.Columns.Add("Примечания");

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
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Ошибка формата: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
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

                            string cellVal = dataGridViewOutPut_KDY.Rows[i].Cells[j].Value?.ToString() ?? string.Empty; // Проверка на null значение ячейки
                            cellVal = cellVal.Replace("\"", "\"\""); // Замена кавычек внутри значения на две кавычки для CSV 
                            strBuilder.Append($"\"{cellVal}\""); // Оборачиваем значение в кавычки

                            // Добавляем разделитель только если это не последний элемент в строке
                            if (j != cols - 1)
                            {
                                strBuilder.Append(","); // Разделяем значения запятой  
                            }
                        }
                        strBuilder.AppendLine(); // Конец строки 
                    }
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("Файл успешно сохранен на ваш компьютер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\nФайл не был сохранен на ваш компьютер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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