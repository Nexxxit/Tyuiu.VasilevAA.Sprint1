using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.VasilevAA.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var res = 3 / 3 * 2 + 12 / 4 / 3 - 2;
            Assert.AreEqual(1, res);
        }
    }
}
