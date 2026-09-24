using Tyuiu.VazhnikLN.Sprint2.Task4.V6.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Valid2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 17;
            var res = ds.Calculate(x, y);
            double wait = 297;
            Assert.AreEqual(wait, res);
        }
    }
}
