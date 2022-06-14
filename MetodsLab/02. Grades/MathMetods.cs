using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Grades
{
    internal class MathMetods
    {
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
        static int GetMax(int input1, int input2)
        {
            if (input1 > input2)
            {
                return input1;
            }

            return input2;

        }
        static char GetMax(char input1, char input2)
        {
            if (input1 > input2)
            {
                return input1;
            }
            return input2;

        }
        static string GetMax(string input1, string input2)
        {
            int result = input1.CompareTo(input2);

            if (result > 0)
            {
                return input1;
            }

            return input2;

        }
        static double GetDivide(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber / secondNumber;

            }
            return secondNumber / firstNumber;
        }

        static double GetSubstract(double firstNumber, double secondNumber)
        {
            return Math.Abs(firstNumber - secondNumber);
        }

        static double GetSum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static double GetMultiple(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static void FirstPartTriangle(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
        static void SeconPartTriangle(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
        static double MathPower(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
