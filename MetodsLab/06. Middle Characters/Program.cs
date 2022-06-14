using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(FindMiddleChars(input));
        }

        static string FindMiddleChars(string input)
        {
            string newLine = string.Empty;
            if (input.Length % 2==0)
            {
                newLine += input[input.Length / 2-1];
                newLine += input[input.Length / 2];
                return newLine;
            }
            else
            {
                newLine += input[input.Length / 2];
                return newLine;
            }
        }
    }
}
