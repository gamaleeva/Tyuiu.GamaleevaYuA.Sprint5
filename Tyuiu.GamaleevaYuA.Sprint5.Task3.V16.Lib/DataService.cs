using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { Path.GetTempPath(), "OutPutFileTask3.bin" };
            string path = Path.Combine(paths);
            double z = (2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(x * x - 2));
            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
