using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YalalovNR.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            int daysInMonth = 31; 
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 29;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }
            if (nextDay > daysInMonth)
            {
                nextDay = 1;       
                nextMonth = m + 1; 
                if (nextMonth > 12)
                {
                    nextMonth = 1;     
                    nextYear = g + 1;   
                }
            }
            return $"{nextYear}, {nextMonth}, {nextDay}";
        }
    }
}