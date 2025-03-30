using System;

namespace Lab2
{
    public class OddEvenCheck
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number.");
            }
        }
    }
}
