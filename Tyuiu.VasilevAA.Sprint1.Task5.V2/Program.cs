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

            double temp;

            Console.WriteLine("Введите температуру по Фаренгейту:");
            temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Температура в градусах Цельсия = " + ds.FahrenheitToСelsius(temp));
            Console.ReadKey();
        }
    }
}
