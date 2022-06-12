using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();


            switch (operation)
            {
                case "int":
                    int inputInt1 = int.Parse(Console.ReadLine());
                    int inputInt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(inputInt1, inputInt2));
                    break;
                case "char":
                    char inputChar1 = char.Parse(Console.ReadLine());
                    char inputChar2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(inputChar1, inputChar2));
                    break;
                case "string":
                    string inputStr1 = Console.ReadLine();
                    string inputStr2 = Console.ReadLine();
                    Console.WriteLine(GetMax(inputStr1, inputStr2));
                    break;
            }
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
    }
}
