using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YalalovNR.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            switch(value)
            {
                case 6:  return ("шестёрка");
                case 7:  return ("семёрка");
                case 8:  return ("восьмёрка"); 
                case 9:  return ("девятка");
                case 10: return ("десятка"); 
                case 11: return ("валет"); 
                case 12: return ("дама"); 
                case 13: return ("король"); 
                case 14: return ("туз");
                default: return "Неизвестная карта";
            }

        }
    }
}
