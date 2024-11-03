using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("please enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }

            Console.WriteLine("Entered number: " + number);
        }
    }
}