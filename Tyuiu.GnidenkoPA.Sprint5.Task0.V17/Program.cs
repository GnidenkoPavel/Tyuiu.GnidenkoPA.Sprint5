using System;
using Tyuiu.GnidenkoPA.Sprint5.Task0.V17.Lib;
namespace Tyuiu.GnidenkoPA.Sprint5.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.4x³ + 0.4x² − 1.4x + 4.1.                       *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат                             *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt                          *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            int x = 3;
            string res = ds.SaveToFileTextData(x);


            Console.WriteLine($"файл создан {res}");

            Console.WriteLine(File.ReadAllText(res));

        }
    }
}