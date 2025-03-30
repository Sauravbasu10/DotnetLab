using System;

namespace Lab2
{
    public class SumOfNaturalNumbers
    {
        public static void Run()
        {
            Console.Write("Enter the number of natural number to sum: ");
            int num = int.Parse(Console.ReadLine());

            int sum = (num * (num + 1)) / 2;

            Console.WriteLine($"The sum of first {num} natural numbers is: {sum}");
        }
    }
}
