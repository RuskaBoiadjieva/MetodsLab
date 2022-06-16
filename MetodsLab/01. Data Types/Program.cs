using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            DataType(type);
            //switch (type)
            //{
            //    case "int":
            //        int number = int.Parse(Console.ReadLine());
            //        MultiplyByTwo(number);
            //       break;
            //    case "real":
            //        double realNumber = double.Parse(Console.ReadLine());
            //        MultiplyByNumber(realNumber);
            //        break;
            //    case "string":
            //        string text = Console.ReadLine();
            //        ChangeString(text);
            //        break;
            //}

        }

        static void DataType(string type)
        {
            switch (type)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number * 2);
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{realNumber * 1.5:f2}");
                    break;
                case "string":
                    string text = Console.ReadLine();
                    Console.WriteLine("$" + text + "$");
                    break;
            }
        }

        //static void ChangeString(string text)
        //{
        //    Console.WriteLine("$" + text + "$");
        //}

        //static void MultiplyByNumber(double realNumber)
        //{
        //    Console.WriteLine($"{realNumber * 1.5:f2}");
        //}

        //static void MultiplyByTwo(int number)
        //{
        //    Console.WriteLine(number * 2);
        //}
    }
}
