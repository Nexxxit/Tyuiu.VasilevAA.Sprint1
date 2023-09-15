using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task7.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;

            Console.WriteLine("Введите х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
