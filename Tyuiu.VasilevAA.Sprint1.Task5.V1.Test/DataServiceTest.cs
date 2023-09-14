using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double x2 = 3;
            double y1 = 2;
            double y2 = 1;
            var res = ds.Calculate(x1 , x2, y1, y2);
            Assert.AreEqual(4, res);
        }
    }
}
