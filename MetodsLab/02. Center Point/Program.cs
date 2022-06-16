using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pointX1 = double.Parse(Console.ReadLine());
            double pointY1 = double.Parse(Console.ReadLine());
            double pointX2 = double.Parse(Console.ReadLine());
            double pointY2 = double.Parse(Console.ReadLine());

            CheckCenterPoint(pointX1, pointY1, pointX2, pointY2);
        }

        static void CheckCenterPoint(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            double distanse1 = Math.Sqrt(Math.Pow(pointX1, 2) + Math.Pow(pointY1, 2));
            double distanse2 = Math.Sqrt(Math.Pow(pointX2, 2) + Math.Pow(pointY2, 2));
            if (distanse1<=distanse2)
            {
                Console.WriteLine($"({pointX1}, {pointY1})");
            }
            else
            {
                Console.WriteLine($"({pointX2}, {pointY2})");
            }
        }
    }
}
