using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

          

            Console.WriteLine(PrintLineOfChar(firstChar, secondChar));
        }

     

        static string PrintLineOfChar(char firstChar, char secondChar)
        {
            char currentChar = ' ';
            if (secondChar < firstChar)
            {
                currentChar = secondChar;
                secondChar = firstChar;
                firstChar = currentChar;
            }
            string newLine = string.Empty;
            for (char i = (char)(firstChar+1); i < secondChar; i++)
            {
                newLine += i + " ";
            }
            return newLine;
        }

        //static string PrintLineOfChars(char firstChar, char secondChar)
        //{
            
        //    string newLine = string.Empty;
        //    for (int i = Math.Min(firstChar,secondChar)+1; i < Math.Max(firstChar, secondChar); i++)
        //    {
        //        newLine += i + " ";
        //    }
        //    return newLine;
        //}
    }
}
