using System;
using Tyuiu.YalalovNR.Sprint2.Task1.V14.Lib; 

namespace Tyuiu.YalalovNR.Sprint2.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

   
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("**************************************************");
            Console.WriteLine("** ИСХОДНЫЕ ДАННЫЕ:                              **");
            Console.WriteLine("**************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("**************************************************");
            Console.WriteLine("** РЕЗУЛЬТАТ:                                    **");
            Console.WriteLine("**************************************************");

         
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine(); 
        }
    }
}