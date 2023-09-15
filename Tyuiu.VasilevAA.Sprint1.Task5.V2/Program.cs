using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double tempFahrenheit;

            Console.WriteLine("Введите температуру по Фаренгейту:");
            tempFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Температура в градусах Цельсия = " + ds.FahrenheitToCelsius(tempFahrenheit));
            Console.ReadKey();
        }
    }
}
