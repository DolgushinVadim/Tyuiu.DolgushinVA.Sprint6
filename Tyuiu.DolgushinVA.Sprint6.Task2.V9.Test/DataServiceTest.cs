﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint6.Task2.V9.Lib;
namespace Tyuiu.DolgushinVA.Sprint6.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 4.34;
            valueWaitArray[1] = 4.16;
            valueWaitArray[2] = 3.71;
            valueWaitArray[3] = 3.27;
            valueWaitArray[4] = 2.93;
            valueWaitArray[5] = 2.5;
            valueWaitArray[6] = 0.71;
            valueWaitArray[7] = -47.61;
            valueWaitArray[8] = 55.15;
            valueWaitArray[9] = 45.17;
            valueWaitArray[10] = 14.97;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
