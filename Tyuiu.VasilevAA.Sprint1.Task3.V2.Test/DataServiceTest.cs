using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VasilevAA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double PriceOfNotebooks = 1;
            int NumberOfNotebooks = 5;
            double  PriceOfPencils = 3;
            int NumberOfPencils = 2;
            var res = ds.PriceOfGoods(PriceOfNotebooks, NumberOfNotebooks, PriceOfPencils, NumberOfPencils);
            Assert.AreEqual(11, res);
        }
    }
}
