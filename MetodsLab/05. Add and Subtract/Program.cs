using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumFirstTwoDigits(num1, num2);
            Console.WriteLine(SubstractTwoDigits(num3, sum));
        }

        static int SubstractTwoDigits(int num3, int sum)
        {
            return sum-num3;
        }

        static int SumFirstTwoDigits(int num1, int num2)
        {
            return num2 + num1;
        }
    }
}
