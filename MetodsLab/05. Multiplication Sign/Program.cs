using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1==0||num2==0||num3==0)
            {
                Console.WriteLine("zero");
                return;
            }

            int sum = 0;
            sum += MultiplicationSign(num1);
            sum += MultiplicationSign(num2);
            sum += MultiplicationSign(num3);

            CheckSign(sum);

        }

        static void CheckSign(int sum)
        {
            if (sum%2!=0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }

        static int MultiplicationSign(double num)
        {
            if (num < 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
