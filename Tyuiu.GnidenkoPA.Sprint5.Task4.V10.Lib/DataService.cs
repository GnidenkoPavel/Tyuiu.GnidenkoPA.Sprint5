using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GnidenkoPA.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string s = str.Replace(".", ",");
            double x = Convert.ToDouble(s);
            double res = Math.Pow(x, 3) * 1.2 * x + 2;
            res = Math.Round(res, 3);
            return res;
        }
    }
}
