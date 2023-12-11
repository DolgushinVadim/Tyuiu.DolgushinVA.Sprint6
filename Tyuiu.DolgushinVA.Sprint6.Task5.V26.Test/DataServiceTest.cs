using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.DolgushinVA.Sprint6.Task5.V26.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\vadim\source\repos\Tyuiu.DolgushinVA.Sprint6\Tyuiu.DolgushinVA.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
