using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            // Ask the user which program to run
            Console.WriteLine("Select a program to run:");
            Console.WriteLine("1. Run Class1");
            Console.WriteLine("2. Run Factorial");

            int choice = int.Parse(Console.ReadLine());

            // Based on the choice, call the corresponding class method
            switch (choice)
            {
                case 1:
                    Hello.Run();
                    break;
                case 2:
                    Factorial.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
