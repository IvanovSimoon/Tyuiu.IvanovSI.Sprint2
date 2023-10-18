using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint2.Task5.V13.Lib;
namespace Tyuiu.IvanovSI.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int n = 23;
            int m = 10;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "24.10.2023";
            Assert.AreEqual(wait, res);

        }
    }
}
