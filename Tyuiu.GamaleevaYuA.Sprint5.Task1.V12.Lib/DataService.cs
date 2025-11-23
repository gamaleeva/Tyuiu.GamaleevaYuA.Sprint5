using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {

            string[] paths = { Path.GetTempPath(), "OutPutFileTask0.txt" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool exist = fileInfo.Exists;
            if (exist)
            {
                File.Delete(path);
            }
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = (5 * i + 2.5) / (Math.Sin(i) - 2) + 2;
                if (double.IsInfinity(f) || double.IsNaN(f))
                {
                    f = 0;
                }
                f = Math.Round(f, 2);
                string y = Convert.ToString(f);
                if (i != stopValue)
                {
                    File.AppendAllText(path, y + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, y);
                }
            }
            return path;
        }
    }
}
