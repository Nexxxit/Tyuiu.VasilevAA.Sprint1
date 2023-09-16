using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VasilevAA.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToCelsius(double tempFahrenheit)
        {
            return Convert.ToInt32((tempFahrenheit - 32) * 5 / 9);
        }
    }
}
