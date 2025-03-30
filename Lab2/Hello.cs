using System;

namespace Lab2
{
    public class Hello
    {
        public static void Run()
        {
            Console.WriteLine("Hello!");
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();  // Ensure semicolon here
            Console.WriteLine("Hello, " + input + "!");  // Ensure semicolon here
        }
    }
}
