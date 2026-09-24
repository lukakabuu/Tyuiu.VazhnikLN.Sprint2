using System;
using Tyuiu.VazhnikLN.Sprint2.Task2.V7.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task2.V7

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
            {
                Console.WriteLine("Точка лежит в фигуре");
            }
            else
            {
                Console.WriteLine("Точка не лежит в фигуре");
            }

        }
    }
}
