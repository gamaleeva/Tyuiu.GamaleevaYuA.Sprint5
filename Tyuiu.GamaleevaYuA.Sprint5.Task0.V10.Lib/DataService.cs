using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { Path.GetTempPath(), "OutPutFileTask0.txt" };
            string path = Path.Combine(paths);
            double f = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
            f = Math.Round(f, 3);
            File.WriteAllText(path, Convert.ToString(f));
            return path;


        }
    }
}
