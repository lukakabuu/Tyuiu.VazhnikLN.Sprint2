using System;
using Tyuiu.VazhnikLN.Sprint2.Task0.V14.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task0.V14

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }


        }
    }
}
