using System;
using Tyuiu.GnidenkoPA.Sprint5.Task4.V10.Lib;
namespace Tyuiu.GnidenkoPA.Sprint5.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение по формуле и возвращает  *");
            Console.WriteLine("* полученный результат                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\avv\Desktop\DataSprint5\InPutDataFileTask4V10.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}