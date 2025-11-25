using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 4; i++)
                    {
                        if (char.IsDigit(line[i]) && char.IsDigit(line[i + 1]) && char.IsDigit(line[i + 2]) && char.IsDigit(line[i + 3]) && char.IsDigit(line[i + 4]))
                        {
                            count++;
                        }
                    }

                }
            }
            return count;
        }
    }
}
