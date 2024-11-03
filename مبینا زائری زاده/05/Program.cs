using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character:");
            char character;

            while (!char.IsLetter(character = Console.ReadKey().KeyChar))
            {
                Console.WriteLine("\nPlease enter only alphabetic characters.");
                Console.Write("Enter a character:");
            }

            Console.WriteLine("\nYou entered the character '{0}'.", character);
        }
    }
}