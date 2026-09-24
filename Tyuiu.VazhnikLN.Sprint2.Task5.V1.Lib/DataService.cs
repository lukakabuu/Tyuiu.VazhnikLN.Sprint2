using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VazhnikLN.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int s;
            switch (value)
            {
                case 1:
                    s = 31;
                    break;
                case 2:
                    s = 28;
                    break;
                case 3:
                    s = 31;
                    break;
                case 4:
                    s = 30;
                    break;
                case 5:
                    s = 31;
                    break;
                case 6:
                    s = 30;
                    break;
                case 7:
                    s = 31;
                    break;
                case 8:
                    s = 31;
                    break;
                case 9:
                    s = 30;
                    break;
                case 10:
                    s = 31;
                    break;
                case 11:
                    s = 30;
                    break;
                case 12:
                    s = 31;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");

            }
            return s;
        }
    }
}
