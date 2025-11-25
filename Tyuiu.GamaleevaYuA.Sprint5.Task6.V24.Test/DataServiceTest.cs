using Tyuiu.GamaleevaYuA.Sprint5.Task6.V24.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedCount()
        {
            string[] paths = { "C:", "DataSprint5", "InPutDataFileTask6V24.txt" };
            string path = Path.Combine(paths);
            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedFileExists()
        {
            string[] paths = { "C:", "DataSprint5", "InPutDataFileTask6V24.txt" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
