using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YalalovNR.Sprint2.Task3.V5.Lib
{
    public class DataService : ISprint2Task3V5
    {
        public double Calculate(double x)
        {
            double y = 0; 

            if (x > 1)
            {
                y = x - Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0) 
            {
                y = (x * x - Math.Cos(x * x)) / (x * x - Math.Sin(x * x) + 12);
            }
            else if (x > -9 && x < 0)
            {
                y = Math.Pow(6 + 4.0 / (x * x), x); 
            }
            else if (x < -9)
            {
                
                y = x * x * x + 10 * x - (x * x) / (x * x * x * x);
            }

        
            return Math.Round(y, 3);
        }
    }
}