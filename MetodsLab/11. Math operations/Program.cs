using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            switch (operand)
            {
                case '*':
                    Console.WriteLine(GetMultiple(firstNumber, secondNumber));
                    break;
                case '+':
                    Console.WriteLine(GetSum(firstNumber, secondNumber));
                    break;
                case '-':
                    Console.WriteLine(GetSubstract(firstNumber, secondNumber));
                    break;
                case '/':
                    Console.WriteLine(GetDivide(firstNumber, secondNumber));
                    break;
            }
        }

        static double GetDivide(double firstNumber, double secondNumber)
        {
            if (firstNumber>secondNumber)
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
    }
}
