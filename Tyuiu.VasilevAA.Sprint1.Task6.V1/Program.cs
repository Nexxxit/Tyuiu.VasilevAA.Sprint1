using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string text;

            Console.WriteLine("Введите символ:");
            text = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.WorkWithText(text));
            Console.ReadKey();
        }
    }
}
