using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 1;
            double h = 2;
            var res = ds.Calculate(r,h);
            Assert.AreEqual(6.28,res);
        }
    }
}
