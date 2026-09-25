using System;
using Tyuiu.VazhnikLN.Sprint2.Task6.V3.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task6.V3

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string res;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер дня:");
            int x = Convert.ToInt16(Console.ReadLine());
            if ((x >= 1) && (x <= 7)) res = "Сегодня " + ds.FindDayName(x); 
            else res = "Введено неверное значение!";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

        }
    }
}