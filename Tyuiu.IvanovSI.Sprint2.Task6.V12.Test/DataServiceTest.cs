using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint2.Task6.V12.Lib;
namespace Tyuiu.IvanovSI.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int n = 1;
            int m = 1;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "31.12.2022";
            Assert.AreEqual(wait, res);
        }
    }
}
