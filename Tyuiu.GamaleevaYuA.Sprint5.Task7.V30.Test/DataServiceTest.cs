namespace Tyuiu.GamaleevaYuA.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string[] paths = { Path.GetTempPath(), "OutPutDataFileTask7V30.txt" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
