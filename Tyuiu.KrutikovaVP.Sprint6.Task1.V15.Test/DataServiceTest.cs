using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint6.Task1.V15.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task1.V15.Test
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
            double[] waitArray = new double[11] { 59.49, 38.47, -2.81, -19.67, -8.42, 0.57, -6.3, -20.14, -3.51, 38.13, 59.6 };
            double[] resArray = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
