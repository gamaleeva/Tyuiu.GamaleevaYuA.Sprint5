using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double res = double.MaxValue;
            string[] strings = strX.Split(' ');
            List<string> nums = new List<string>();
            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number) && number % 4 == 0 && number < res )
                {
                    res = number;
                }
            }
            return res;
        }
    }
}
