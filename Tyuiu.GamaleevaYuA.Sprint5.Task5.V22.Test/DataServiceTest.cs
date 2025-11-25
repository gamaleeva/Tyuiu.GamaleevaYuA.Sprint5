using System.IO;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string[] paths = { "C:", "DataSprint5", "InPutDataFileTask5V22.txt" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
