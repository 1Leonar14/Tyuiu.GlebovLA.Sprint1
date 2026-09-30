using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GlebovLA.Sprint1.Task2.V23.Lib;
//ISprint1Task2V23.ConvertMinutesToSeconds(int)
namespace Tyuiu.GlebovLA.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMinutesToSeconds(x);
            Assert.AreEqual(120, res);
        }
    }
}
