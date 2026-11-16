using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YalalovNR.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (
                
                (y == 2 && x >= 6 && x <= 7) ||

                
                (y == 3 && ((x >= 3 && x <= 7) || x == 11)) ||

                
                (y == 4 && ((x >= 3 && x <= 7) || x == 11)) ||

                
                (y == 5 && ((x >= 3 && x <= 7) || x == 11)) ||

               
                (y == 6 && x >= 5 && x <= 11) ||

                
                (y == 7 && x >= 5 && x <= 12) ||


                (y == 8 && x >= 5 && x <= 9) ||

                
                (y == 9 && x >= 6 && x <= 9) ||

                
                (y == 10 && x >= 8 && x <= 9) ||

               
                (y == 11 && x >= 8 && x <= 11) ||

                
                (y == 12 && x >= 3 && x <= 11) ||

                
                (y == 13 && x >= 5 && x <= 8)
               )
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
    
}