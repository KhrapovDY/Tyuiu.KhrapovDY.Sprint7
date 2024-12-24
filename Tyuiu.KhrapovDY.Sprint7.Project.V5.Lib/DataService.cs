using System.Data;

namespace Tyuiu.KhrapovDY.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        static double[] RemoveLastElement(double[] array)
        {
            if (array.Length == 0)
            {
                return array;
            }

            double[] newArray = new double[array.Length - 1];

            Array.Copy(array, newArray, array.Length - 1);

            return newArray;
        }

        public double FindMiddleValue(double[] array) // Нахождение среднего значения элемента
        {
            array = RemoveLastElement(array);
            return Math.Round(array.Sum() / (array.Length), 3);
        }

        public double FindTotalValue(double[] array) // Нахожение суммы элемента
        {
            array = RemoveLastElement(array);
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return Math.Round(result, 3);
        }

        public double FindMinValue(double[] array) // Нахождение минимального значения элемента
        {
            return array.Min();
        }

        public double FindMaxValue(double[] array) // Нахождение максимального значения элемента
        {
            return array.Max();
        }

        public string[,] LoadFromFileData(string filepath)
        {
            // Проверка
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Файл не найден.", filepath);
            }


            string[] lines = File.ReadAllLines(filepath);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;

            string[,] data = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length != columns)
                {
                    throw new FormatException("Некорректный формат данных в строке: " + lines[i]);
                }

                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = values[j];
                }
            }

            return data;
        }
    }
}
