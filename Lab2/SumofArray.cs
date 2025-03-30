using System;

namespace Lab2
{
    public class SumOfArrayElements
    {
        public static void Run()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine($"The sum of the array elements is: {sum}");
        }
    }
}
