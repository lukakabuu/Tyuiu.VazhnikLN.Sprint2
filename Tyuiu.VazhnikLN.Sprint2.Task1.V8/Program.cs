using System;
using Tyuiu.VazhnikLN.Sprint2.Task1.V8.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task1.V8

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a, b, c, d;
            a = 15;
            b = 16;
            c = 14;
            d = 335;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
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

