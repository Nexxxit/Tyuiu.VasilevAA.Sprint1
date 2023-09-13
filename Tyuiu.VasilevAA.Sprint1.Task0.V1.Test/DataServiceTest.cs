using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.VasilevAA.Sprint1.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var res = 36/2/9+1-6/2*3;
            Assert.AreEqual(-6,res);
        }
    }
}
