﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.DolgushinVA.Sprint6.Task6.V18.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\vadim\source\repos\Tyuiu.DolgushinVA.Sprint6\Tyuiu.DolgushinVA.Sprint6.Task6.V18\bin\Debug\InPutFileTask6V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
