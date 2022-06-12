using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(length, heigth));
        }

        static double CalculateRectangleArea(double length, double heigth)
        {
            return length * heigth;
        }
    }
}
