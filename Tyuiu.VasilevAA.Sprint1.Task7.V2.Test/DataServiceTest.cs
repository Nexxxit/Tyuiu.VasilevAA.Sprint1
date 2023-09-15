﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task7.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-5.103, res);
        }
    }
}
