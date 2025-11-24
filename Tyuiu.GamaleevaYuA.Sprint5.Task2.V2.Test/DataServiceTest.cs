namespace Tyuiu.GamaleevaYuA.Sprint5.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string[] paths = { "C:", "Users", "Юлия", "AppData", "Local", "Temp", "OutPutFileTask2.csv" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
