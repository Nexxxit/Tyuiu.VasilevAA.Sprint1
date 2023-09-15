using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task7.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 4;
            double c = 5;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(-28.579, res);
        }
    }
}
