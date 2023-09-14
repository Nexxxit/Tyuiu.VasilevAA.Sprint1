using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task1.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 2;
            double a = 1;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(7,5, res);
        }
    }
}
