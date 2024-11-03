//using System;

namespace MirrorNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter number 1:");
            int start = int.Parse(Console.ReadLine());

            Console.Write("please enter number 2: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Mirror numbers between {0} and {1} are:", start, end);

            for (int number = start; number <= end; number++)
            {
                if (IsMirrorNumber(number))
                {
                    Console.Write(number + " ");
                }
            }
        }

        static bool IsMirrorNumber(int number)
        {
            int reversed = 0;
            int original = number;

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return original == reversed;
        }
    }
}
