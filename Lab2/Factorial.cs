using System;

namespace Lab2
{
    public class Factorial
    {
        public static void Run()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int num = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {num} is: {factorial}");
        }
    }
}
