using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool res = ds.WorkWithText(text);
            Assert.AreEqual(true, res);
        }
    }
}
