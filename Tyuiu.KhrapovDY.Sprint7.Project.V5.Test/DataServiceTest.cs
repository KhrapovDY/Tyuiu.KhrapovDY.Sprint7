using Tyuiu.KhrapovDY.Sprint7.Project.V5.Lib;
namespace Tyuiu.KhrapovDY.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filepath = @"C:\Users\User\Desktop\hhhh\ProjectImages\InPutDataFileProjectV5.txt";

            AddDataToCSV(filepath);
        }

        private void AddDataToCSV(string filepath)
        {
            try
            {
                using (var writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}