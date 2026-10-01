using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint1.Task4.V22.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.054, res);
        }
    }
}