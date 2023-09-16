﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VasilevAA.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public double DistanceBetweenDots(double x1, double x2, double y1, double y2)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))); 
        }
    }
}
