using System;
using Tyuiu.VazhnikLN.Sprint2.Task5.V1.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task5.V1

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
            Console.WriteLine("Введите номер месяца:");
            int x = Convert.ToInt16(Console.ReadLine());
            if ((x >= 1) && (x <= 12)) res = "Количество дней в месяце = " + ds.FindMonthDaysCount(x);
            else res = "Введено неверное значение!";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

        }
    }
}
