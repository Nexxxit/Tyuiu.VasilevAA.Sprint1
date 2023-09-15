using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task7.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double a, b, c;

            Console.WriteLine("Введите а:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.Calculate(a, b, c));
            Console.ReadKey();
        }
    }
}
