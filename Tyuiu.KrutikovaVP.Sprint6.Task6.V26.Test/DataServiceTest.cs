using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KrutikovaVP.Sprint6.Task6.V26.Lib;
namespace Tyuiu.KrutikovaVP.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.KrutikovaVP.Sprint6\Tyuiu.KrutikovaVP.Sprint6.Task6.V26\bin\Debug\InPutFileTask6V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
