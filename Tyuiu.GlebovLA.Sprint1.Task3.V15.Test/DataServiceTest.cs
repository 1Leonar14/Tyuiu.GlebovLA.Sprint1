using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            //ISprint1Task3V15.DistanceOverTime(double, double, double, double)
            double v1 = 60;
            double v2 = 40;
            double S = 500;
            double T = 3;
            double res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(800, res);
        }
    }
}