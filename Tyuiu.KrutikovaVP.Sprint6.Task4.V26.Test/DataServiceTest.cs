using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint6.Task4.V26.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startStep = -5;
            int stopStep = 5;
            double[] waitArray = new double[11] { 19.81, 16.79, 13.87, 10.98, 7.94, 3, 3.23, -0.45, -3.79, -6.97, -10 };
            double[] resArray = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
