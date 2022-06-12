using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operand = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (operand)
            {
                case "add":
                    Console.WriteLine(AddTwoNumbers(firstNum, secondNum));
                    break;
                case "multiply":
                    Console.WriteLine(MultiplyTwoNumbers(firstNum, secondNum));
                    break;
                case "subtract":
                    Console.WriteLine(SubtractTwoNumbers(firstNum, secondNum));
                    break;
                case "divide":
                    Console.WriteLine(DivideTwoNumbers(firstNum, secondNum));
                    break;
                
            }
        }

        static int DivideTwoNumbers(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }

        static int SubtractTwoNumbers(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        static int MultiplyTwoNumbers(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        static int AddTwoNumbers(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
