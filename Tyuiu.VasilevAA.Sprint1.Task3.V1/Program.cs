using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double r, h;

            Console.WriteLine("Введите радиус основания:");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту:");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Объём цилиндра равен" + ds.CylinderVolume(r, h));
            Console.ReadKey();

        }
    }
}
