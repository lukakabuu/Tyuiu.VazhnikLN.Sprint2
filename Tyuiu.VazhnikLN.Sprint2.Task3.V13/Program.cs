using System;
using Tyuiu.VazhnikLN.Sprint2.Task3.V13.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task3.V13

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x);
            Console.WriteLine("Значение функции = " + res);

        }
    }
}
