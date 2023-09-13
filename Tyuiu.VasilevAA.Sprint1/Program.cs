using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VasilevAA.Sprint1.Task0.V1.Lib;

namespace Tyuiu.VasilevAA.Sprint1.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
