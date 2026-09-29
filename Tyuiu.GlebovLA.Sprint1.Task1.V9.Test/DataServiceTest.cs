using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint1.Task1.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task1.V9.Test
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

            double result = ds.Calculate(x, y);
            Assert.AreEqual(0.5, result);
        }
    }
}