using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            TribonacciSequence(num);

        }

        static void TribonacciSequence(int n)
        {
            if (n == 1)
            {
                Console.Write(1);
            }
            else if (n == 2)
            {
                Console.Write("1 1");
            }
            else if (n==3)
            {
                Console.Write("1 1 2");
            }
            else
            {

                int[] tribonacci = new int[n];
                tribonacci[0] = 1;
                tribonacci[1] = 1;
                tribonacci[2] = 2;

                for (int i = 3; i < n; i++)
                {
                    tribonacci[i] = tribonacci[i - 3] + tribonacci[i - 2] + tribonacci[i - 1];
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(tribonacci[i] + " ");
                }
            }

        }
    }
}
