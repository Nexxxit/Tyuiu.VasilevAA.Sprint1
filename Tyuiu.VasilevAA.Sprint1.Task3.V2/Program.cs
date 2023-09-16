using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double PriceOfNotebooks, PriceOfPencils;
            int NumberOfNotebooks, NumberOfPencils;

            Console.WriteLine("Введите цену тетради:");
            PriceOfNotebooks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Количество тетрадей:");
            NumberOfNotebooks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите цену карандаша:");
            PriceOfPencils = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество карандашей:");
            NumberOfPencils = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(PriceOfNotebooks,NumberOfNotebooks,PriceOfPencils,NumberOfPencils);
            Console.ReadKey();
        }
    }
}
