﻿using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = FactorialOfNum(num1) / FactorialOfNum(num2);
            Console.WriteLine($"{result:f2}");
        }

        static decimal FactorialOfNum(int num)
        {
            decimal factorialNum = 1;
            for (int i = 1; i <= num; i++)
            {
                factorialNum *= i;
            }
            return factorialNum;
        }
    }
}
