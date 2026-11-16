using System;
using Tyuiu.YalalovNR.Sprint2.Task2.V18.Lib;
namespace Tyuiu.YalalovNR.Sprint2.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** ИСХОДНЫЕ ДАННЫЕ:      ****");
            Console.WriteLine("******************************");

            Console.Write("Введите значение переменной X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("******************************");
            Console.WriteLine("** РЕЗУЛЬТАТ:               **");
            Console.WriteLine("******************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}