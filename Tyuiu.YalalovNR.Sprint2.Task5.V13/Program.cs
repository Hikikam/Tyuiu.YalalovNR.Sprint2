using System;
using Tyuiu.YalalovNR.Sprint2.Task5.V13.Lib;
namespace Tyuiu.YalalovNR.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;

            if (m < 1 || m > 12 || n < 1 || n > 31)
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = ds.FindDateOfNextDay(g, m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}