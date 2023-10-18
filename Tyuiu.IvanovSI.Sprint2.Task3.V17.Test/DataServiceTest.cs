using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint2.Task3.V17.Lib;
namespace Tyuiu.IvanovSI.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 6565;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.286;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 16;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckCalculate4()
        {
            DataService ds = new DataService();
            double x = -22;
            double res = ds.Calculate(x);
            double wait = -241.955;
            Assert.AreEqual(wait, res);
        }
    }
}
