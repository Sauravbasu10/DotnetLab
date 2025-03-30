using System;

namespace Lab2
{
    public class PrimeCheck
    {
        public static void Run()
        {
            Console.Write("Enter a number to check if it is prime: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine($"{num} is not a prime number.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }
    }
}
