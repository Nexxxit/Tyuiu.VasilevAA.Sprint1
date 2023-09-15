﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double tempFahrenheit = 5;
            var res = ds.FahrenheitToCelsius(tempFahrenheit);
            Assert.AreEqual(tempFahrenheit, res);

        }
    }
}
