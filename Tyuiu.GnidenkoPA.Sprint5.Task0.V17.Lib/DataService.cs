using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GnidenkoPA.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double res = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;

            res = Math.Round(res, 3);

            File.WriteAllText(path, res.ToString());

            return path;

        }
    }
}
