using System;

namespace FibonacciChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsFibonacci(number))
            {
                Console.WriteLine("The entered number is in the Fibonacci series.");
            }
            else
            {
                Console.WriteLine("The entered number is not in the Fibonacci series.");
            }
        }

        static bool IsFibonacci(int num)
        {
            int a = 0, b = 1;
            while (b <= num)
            {
                if (b == num)
                {
                    return true;
                }
                int temp = b;
                b = a + b;
                a = temp;
            }
            return false;
        }
    }
}