using System.IO;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExisits()
        {
            string[] paths = { "C:", "DataSprint5", "InPutDataFileTask4V23.txt" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
