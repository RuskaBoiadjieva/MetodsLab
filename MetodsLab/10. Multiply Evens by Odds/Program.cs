using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(number), GetSumOfOddDigits(number)));

        }

        static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            int currentNum = Math.Abs(number);
            while (currentNum > 0)
            {
                int currentDigit = currentNum % 10;
                if (currentDigit % 2 != 0)
                {
                    sumOdd += currentDigit;
                }
                currentNum = currentNum / 10;
            }

            return sumOdd;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            int currentNum = Math.Abs(number);
            while (currentNum > 0)
            {
                int currentDigit = currentNum % 10;
                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
                currentNum = currentNum / 10;
            }

            return sumEven;
        }
    }
}
