using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number 1:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter number 2:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1} include:", start, end);

            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

