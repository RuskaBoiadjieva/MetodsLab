using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            string typeOfProduct = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            //The prices for a single item of each product are:
            //•	coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00

            switch (typeOfProduct)
            {
                case "coffee":
                    Console.WriteLine($"{ Coffee(quantity):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{ Water(quantity):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{ Coke(quantity):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{ Snacks(quantity):f2}");
                    break;
            }


            //Print the result, rounded to the second decimal place.

        }

        static double Coffee(int quantity)
        {
            return quantity * 1.5;

        }
        static double Water(int quantity)
        {
            return quantity * 1.00;

        }
        static double Coke(int quantity)
        {
            return quantity * 1.4;

        }
        static double Snacks(int quantity)
        {
            return quantity * 2.00;

        }
    }
}
