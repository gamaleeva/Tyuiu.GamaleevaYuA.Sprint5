using System.IO;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string[] paths = { "C:", "Users", "Юлия", "AppData", "Local", "Temp", "OutPutFileTask0.txt" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
