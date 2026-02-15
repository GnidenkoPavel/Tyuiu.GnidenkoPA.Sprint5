using System;
using Tyuiu.GnidenkoPA.Sprint5.Task2.V19.Lib;
namespace Tyuiu.GnidenkoPA.Sprint5.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан целочисленный массив 3x3. Заменить нечётные элементы на 0           *");
            Console.WriteLine("* и сохранить результат в файл OutPutFileTask2.csv                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int[,] matrix = new int[3, 3];
            Console.WriteLine("Введите элементы матрицы 3x3:");

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine();
            Console.WriteLine($"Результат сохранён в файл: {path}");
        }
    }
}