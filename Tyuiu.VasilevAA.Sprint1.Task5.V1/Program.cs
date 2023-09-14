using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x1, x2, y1, y2;

            Console.WriteLine("Введите X1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.Calculate(x1,x2,y1,y2));
            Console.ReadKey();

        }
    }
}
