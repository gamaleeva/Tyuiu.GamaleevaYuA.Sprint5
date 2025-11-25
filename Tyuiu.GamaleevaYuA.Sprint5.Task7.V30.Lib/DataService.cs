using System.IO;
using System.Reflection.Metadata;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GamaleevaYuA.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string[] pathssave = [Path.GetTempPath(), "OutPutDataFileTask7V30.txt"];
            string pathsaved = Path.Combine(pathssave);
            FileInfo fileinfo = new FileInfo(pathsaved);
            bool fileexists = fileinfo.Exists;
            if (fileexists)
            {
                File.Delete(pathsaved);
            }
            string strline = "";
            using ( StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1;  i < line.Length - 1; i++)
                    {
                        
                        if (line[i - 1] == ' ' && char.IsDigit(line[i]) && line[i + 1] == ' ')
                        {
                            strline += "9";
                        }
                        else
                        {
                            strline += line[i];
                        }
                       
                    }
                    File.AppendAllText(pathsaved, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return pathsaved;
        }
    }
}
