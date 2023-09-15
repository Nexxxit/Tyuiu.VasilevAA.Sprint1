﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "1";
            var res = ds.WorkWithText(text);
            Assert.AreEqual("49", res);
        }
    }
}
