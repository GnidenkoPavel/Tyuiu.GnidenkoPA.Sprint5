using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GnidenkoPA.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double mult = 1;

            string str = File.ReadAllText(path);
            string[] chisla = str.Split(' ');

            for (int i = 0; i < chisla.Length; i++)
            {
                chisla[i] = chisla[i].Replace(".", ",");

                double temp = Convert.ToDouble(chisla[i]);
                if (temp % 1 != 0) mult *= temp;
            }

            return Math.Round(mult, 3);
        }
    }
}
