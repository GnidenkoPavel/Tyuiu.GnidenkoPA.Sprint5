using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GnidenkoPA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Входной файл {path} не найден.");

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = ReplaceLowercaseRussianToUpper(lines[i]);
            }

            // Сохраняем результат во временную папку с фиксированным именем
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V12.txt");
            File.WriteAllLines(outputPath, lines, Encoding.UTF8);

            return outputPath;
        }

        private string ReplaceLowercaseRussianToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                // Диапазоны строчных русских букв: а-я (0x0430–0x044F) и ё (0x0451)
                if ((c >= 0x0430 && c <= 0x044f) || c == 0x0451)
                {
                    if (c == 0x0451) // ё
                        chars[i] = '\x0401'; // Ё
                    else
                        chars[i] = (char)(c - 0x20); // для а-я -> А-Я (разница 0x20)
                }
            }
            return new string(chars);
        }
    }
}