using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint6.Task0.V26.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            var wait = 0.769;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
