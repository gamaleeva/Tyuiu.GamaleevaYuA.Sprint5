using Microsoft.Testing.Platform.Extensions.Messages;
using System.Diagnostics;
using Tyuiu.GamaleevaYuA.Sprint5.Task0.V10.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.IO;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExsistFile()
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
