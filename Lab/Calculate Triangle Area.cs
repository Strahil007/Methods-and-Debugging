﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(width, height));
        }
    }
}
