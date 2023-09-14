using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task1.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x, y, a;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение А:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x,y,a));

            Console.ReadLine();
        }
    }
}
