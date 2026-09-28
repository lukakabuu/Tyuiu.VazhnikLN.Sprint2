using System;
using Tyuiu.VazhnikLN.Sprint2.Task7.V9.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task7.V9

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true) Console.WriteLine("Точка с введеными координатами лежит в заданной области");
            else Console.WriteLine("Точка с введеными координатами не лежит в заданной области");
        }
    }
}
