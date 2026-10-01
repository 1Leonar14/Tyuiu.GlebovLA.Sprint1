using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint1.Task7.V6.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(-46.438, res);
        }
    }
}