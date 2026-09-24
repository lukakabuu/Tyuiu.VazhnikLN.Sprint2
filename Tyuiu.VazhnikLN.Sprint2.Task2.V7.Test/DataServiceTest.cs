using Tyuiu.VazhnikLN.Sprint2.Task2.V7.Lib;
using System.ComponentModel.DataAnnotations;

namespace Tyuiu.VazhnikLN.Sprint2.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
