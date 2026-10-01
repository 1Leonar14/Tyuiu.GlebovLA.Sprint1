using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "параллелепипед";
            bool res = ds.CheckeFirstLetterRepetition(value);
            Assert.AreEqual(false, res);
        }
    }
}