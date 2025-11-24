namespace Tyuiu.GamaleevaYuA.Sprint5.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string[] paths = { "C:", "Users", "Юлия", "AppData", "Local", "Temp", "OutPutFileTask3.bin" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
