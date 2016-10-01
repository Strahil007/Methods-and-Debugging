using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = raiseToPower(number, power);
            Console.WriteLine(result);
        }
        private static double raiseToPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}