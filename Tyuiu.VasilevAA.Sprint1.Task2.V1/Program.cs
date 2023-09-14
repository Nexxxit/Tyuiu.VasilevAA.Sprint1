using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VasilevAA.Sprint1.Task2.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ds.ConvertKmToM(x));

            Console.ReadKey();
        }
    }
}
