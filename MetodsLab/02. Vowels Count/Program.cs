using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(CountVowels(input));
        }

        static int CountVowels(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'o' || input[i] == 'i' || input[i] == 'u'
                        || input[i] == 'A' || input[i] == 'E' || input[i] == 'O' || input[i] == 'I' || input[i] == 'U')
                {
                    count ++;
                }
            }
            return count;
        }
        //static int CountVowels(string input)
        //{
        //    int count = 0;
        //    char[] newArrayChar = new char[] { 'a', 'i', 'e', 'o', 'u', 'y', 'A', 'O', 'E', 'I', 'U', 'Y' };
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (newArrayChar.Contains(input[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
