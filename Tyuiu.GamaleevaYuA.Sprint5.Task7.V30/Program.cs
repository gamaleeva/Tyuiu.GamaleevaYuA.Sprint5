using Tyuiu.GamaleevaYuA.Sprint5.Task7.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V24.txt                       *");
        Console.WriteLine("* Найти количество пятизначных чисел в заданной строке.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string[] paths = { "C:", "DataSprint5", "InPutDataFileTask7V30.txt" };
        string path = Path.Combine(paths);
        string[] pathssave = { Path.GetTempPath(), "OutPutDataFileTask7V30.txt" };
        string pathsave = Path.Combine(pathssave);
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Находится в файле: ");
        pathsave = ds.LoadDataAndSave(path);
        Console.WriteLine(pathsave);
        Console.ReadKey();
    }
}