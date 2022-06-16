using System;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void LongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1 = Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2);
            double line2 = Math.Pow(x3-x4, 2) + Math.Pow(y3-y4, 2);
            
            

            if (line1>=line2)
            {
                CheckCloserPoint(x1, y1, x2, y2);
            }
            else
            {
                CheckCloserPoint(x3, y3, x4, y4);
            }

            
            

        }
        static void CheckCloserPoint(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            double distanse1 = Math.Pow(pointX1, 2) + Math.Pow(pointY1, 2);
            double distanse2 = Math.Pow(pointX2, 2) + Math.Pow(pointY2, 2);
            if (distanse1 <= distanse2)
            {
                Console.WriteLine($"({pointX1}, {pointY1})({pointX2}, {pointY2})");
            }
            else
            {
                Console.WriteLine($"({pointX2}, {pointY2})({pointX1}, {pointY1})");
            }
        }

    }
}
