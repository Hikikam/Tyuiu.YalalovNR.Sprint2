using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YalalovNR.Sprint2.Task4.V23.Lib
{
    public class DataService : ISprint2Task4V0
    {
        public double Calculate(double x, double y)
        {

            double z = (x / 2 < Math.Sqrt(y) / 3) ? Math.Pow(1 + 1.0 / (y * y), x): y + 12 * x - (1 / x);

            return Math.Round(z, 3);
        }
    }
}