using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VasilevAA.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PriceOfGoods(double PriceOfNotebooks, int NumberOfNotebooks, double PriceOfPencils, int NumberOfPencils)
        {
            return PriceOfNotebooks * NumberOfNotebooks + PriceOfPencils * NumberOfPencils;
        }
    }
}
