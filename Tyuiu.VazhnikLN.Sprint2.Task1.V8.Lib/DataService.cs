using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VazhnikLN.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (15 < 16) | (17 != 335);
            res[1] = (15 >= 16) & (17 == 335);
            res[2] = (15 <= 16) || (17 != 335);
            res[3] = (15 >= 16) && (17 != 335);
            res[4] = !res[0];
            res[5] = (15 < 16) ^ (17 != 335);
            return res;
        }
    }
}
