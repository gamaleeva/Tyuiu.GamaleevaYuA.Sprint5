using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GamaleevaYuA.Sprint5.Task2.V2.Lib
{
    public class DataService : ISprint5Task2V2
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string[] paths = { Path.GetTempPath(), "OutPutFileTask2.csv" };
            string path = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(path);
            bool exist = fileInfo.Exists;
            if (exist)
            {
                File.Delete(path);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else matrix[i, j] = 0;
                }
            }
            string str = "";
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";

            }
            return path;
        }
    }
}
