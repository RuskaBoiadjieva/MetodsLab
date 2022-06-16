using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int i = 1; i <= end; i++)
            {
                bool rule1 = IsSumDivisibleBy8(i);
                bool rule2 = IsHoldOddDigit(i);
                if (rule1 && rule2)
                {
                    Console.WriteLine(i);
                }
            }

        }
        static bool IsSumDivisibleBy8(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 8 == 0 && sum != 0)
            {
                return true;
            }

            return false;
        }
        static bool IsHoldOddDigit(int num)
        {
            int currentNum = 1;
            while (num > 0)
            {
                currentNum = num % 10;
                if (currentNum% 2 != 0)
                {
                    return true;
                }
                num /= 10;

            }
            return false;
        }
    }
}
