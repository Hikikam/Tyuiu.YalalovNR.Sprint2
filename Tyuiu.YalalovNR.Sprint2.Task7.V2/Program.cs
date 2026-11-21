using System;
using Tyuiu.YalalovNR.Sprint2.Task7.V2.Lib;
namespace Tyuiu.YalalovNR.Sprint2.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x}; {y}) ПОПАДАЕТ в заштрихованную область.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}; {y}) НЕ ПОПАДАЕТ в заштрихованную область.");
            }

            Console.ReadKey();
        }
    }
}