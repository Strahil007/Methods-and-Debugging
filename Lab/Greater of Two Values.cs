using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class GreaterofTwoValues
    {
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return GetMax;
            }
        }
        static char GetMax(char first, char second)
        {
            if ()
            {

            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return GetMax;
            }
        }
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
            }
            else if (type == "string")
            {
            }
        }
    }
}
