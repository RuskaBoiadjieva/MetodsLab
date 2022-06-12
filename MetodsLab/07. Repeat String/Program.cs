using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            RepeatString(input, repeat);
        }

        static void RepeatString(string input, int repeat)
        {
            string newString = string.Empty;
            for (int i = 0; i < repeat; i++)
            {
                newString += input;
            }
            Console.WriteLine(newString);
        }
    }
}
