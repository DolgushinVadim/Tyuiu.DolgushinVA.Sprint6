using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.DolgushinVA.Sprint6.Task7.V15.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\vadim\source\repos\Tyuiu.DolgushinVA.Sprint6\Tyuiu.DolgushinVA.Sprint6.Task7.V15\bin\Debug\InPutFileTask7V15.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
