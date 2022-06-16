using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number!="END")
            {
                Console.WriteLine(CheckIsPalindrom(number));

                number = Console.ReadLine();
            }
        }

        static bool CheckIsPalindrom(string number)
        {
            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i]!=number[number.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
