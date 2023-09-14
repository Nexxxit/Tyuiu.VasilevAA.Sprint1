﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task2.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 180;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(3.142, res);
        }
    }
}
