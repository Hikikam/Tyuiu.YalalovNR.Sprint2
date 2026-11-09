using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YalalovNR.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 1 == y;
            res[1] = x - 930 != y;
            res[2] = x < y;
            res[3] = y + 2 > x;
            res[4] = x <= y;
            res[5] = y + 3 >= x;
            return res;
        }
    }
}
