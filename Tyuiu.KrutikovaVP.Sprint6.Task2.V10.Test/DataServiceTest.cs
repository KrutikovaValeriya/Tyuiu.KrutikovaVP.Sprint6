using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint6.Task2.V10.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.Task2.V10.Test
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
            double[] waitArray = new double[11] { -19.62, -17.12, -18.15, -63.13, -24.92, -5, -1.46, 1.57, 6.38, 32.78, 225.11 };
            double[] resArray = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
