using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task2.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x;

            Console.WriteLine("Введите угол в градусах:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ds.ConvertAngleToRad(x));
            Console.ReadKey();
        }
    }
}
