using Tyuiu.VazhnikLN.Sprint2.Task3.V13.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            int x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            int x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(wait, res);
        }
    }
}
