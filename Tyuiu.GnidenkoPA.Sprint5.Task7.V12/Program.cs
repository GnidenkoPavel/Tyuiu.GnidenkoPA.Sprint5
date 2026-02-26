using System;
using System.IO;
using System.Text;
using Tyuiu.GnidenkoPA.Sprint5.Task7.V12.Lib;

namespace Tyuiu.GnidenkoPA.Sprint5.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Обработка символьных данных                                      *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнил: Гниденко П.А.                                                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл во временной папке: InPutDataFileTask7V12.txt. Заменить      *");
            Console.WriteLine("* все строчные русские буквы на заглавные. Результат сохранить в файл    *");
            Console.WriteLine("* OutPutDataFileTask7V12.txt.                                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string tempDir = Path.GetTempPath();
            string inputFileName = "InPutDataFileTask7V12.txt";
            string inputPath = Path.Combine(tempDir, inputFileName);

            Console.WriteLine($"Путь к входному файлу: {inputPath}");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Файл {inputPath} не найден. Убедитесь, что файл существует.");
                return;
            }

            Console.WriteLine("Содержимое исходного файла:");
            string[] sourceLines = File.ReadAllLines(inputPath, Encoding.UTF8);
            foreach (string line in sourceLines)
                Console.WriteLine(line);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine($"Обработка завершена. Результат сохранён в файл: {outputPath}");

            if (File.Exists(outputPath))
            {
                Console.WriteLine("Содержимое выходного файла:");
                string[] resultLines = File.ReadAllLines(outputPath, Encoding.UTF8);
                foreach (string line in resultLines)
                    Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}