using System;

namespace Lab2
{
    public class SwapNumbers
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }
}
