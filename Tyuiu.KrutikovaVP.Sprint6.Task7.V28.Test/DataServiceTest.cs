using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace Tyuiu.KrutikovaVP.Sprint6.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.KrutikovaVP.Sprint6\Tyuiu.KrutikovaVP.Sprint6.Task7.V28\bin\Debug\InPutFileTask7V28.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
