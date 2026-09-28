using Tyuiu.VazhnikLN.Sprint2.Task7.V9.Lib;
namespace Tyuiu.VazhnikLN.Sprint2.Task7.V9.Test;

[TestClass]
public sealed class DataServiceTest
{

    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService ds = new DataService();
        double x = 3.14 / 2;
        double y = 0;
        bool wait = true;
        bool res = ds.CheckDotInShadedArea(x, y);
        Assert.AreEqual(wait, res);
    }
}
