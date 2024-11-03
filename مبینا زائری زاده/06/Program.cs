using System;

namespace TreeDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you hungry? (Yes/No)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Do you crave spicy food? (yes/no)");
                answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("Are you a vegetarian? (yes/no)");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        Console.WriteLine("I suggest you try the grilled bell pepper with spicy sauce.");
                    }
                    else
                    {
                        Console.WriteLine("I suggest ordering spicy chicken with saffron rice.");
                    }
                }
                else
                {
                    Console.WriteLine("Do you like seafood? (yes/no)");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        Console.WriteLine("I suggest ordering fried shrimp.");
                    }
                    else
                    {
                        Console.WriteLine("I suggest you order pasta alfredo.");
                    }
                }
            }
            else
            {
                Console.WriteLine("So don't eat anything for now!");
            }
        }
    }
}