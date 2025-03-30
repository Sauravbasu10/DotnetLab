using System;

namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("Select a program to run:");
                Console.WriteLine("1. Print Hello and Name");
                Console.WriteLine("2. Swap Two Numbers");
                Console.WriteLine("3. Find Largest of Three Numbers");
                Console.WriteLine("4. Check Even or Odd");
                Console.WriteLine("5. Sum of n Natural Numbers");
                Console.WriteLine("6. Check Leap Year");
                Console.WriteLine("7. Sum of Array Elements");
                Console.WriteLine("8. Calculate Factorial");
                Console.WriteLine("9. Check Prime Number");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Hello.Run();
                        break;
                    case 2:
                        SwapNumbers.Run();
                        break;
                    case 3:
                        LargestNumber.Run();
                        break;
                    case 4:
                        OddEvenCheck.Run();
                        break;
                    case 5:
                        SumOfNaturalNumbers.Run();
                        break;
                    case 6:
                        LeapYearCheck.Run();
                        break;
                    case 7:
                        SumOfArrayElements.Run();
                        break;
                    case 8:
                        Factorial.Run();
                        break;
                    case 9:
                        PrimeCheck.Run();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.Write("Do you want to continue? (yes/no): ");
                string response = Console.ReadLine().Trim().ToLower();
                continueProgram = (response == "yes");
            }
        }
    }
}
