using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string text;

            Console.WriteLine("Введите текст:");
            text = Console.ReadLine();

            Console.WriteLine(ds.WorkWithText(text));
            Console.ReadKey();
        }
    }
}
