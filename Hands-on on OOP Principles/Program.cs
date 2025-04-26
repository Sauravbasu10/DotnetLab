using OOP;

internal class Program
{
    public static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Clear();
            Console.WriteLine("Select a program to run:");
            Console.WriteLine("1. Function OVerlaoding");
            Console.WriteLine("2. Inheritance");
            Console.WriteLine("3. Function Overriding");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Function_overloading fn = new Function_overloading();
                    Console.WriteLine(fn.Add(2, 4));
                    Console.WriteLine(fn.Add(4.2, 33.4));
                    Console.WriteLine(fn.Muliply(2, 4));
                    Console.WriteLine(fn.Muliply(2.2, 4.2));
                    break;

                case 2:
                    Inheritance inheritance = new Inheritance();
                    Console.WriteLine($"Sum: {inheritance.Add(2.3, 22.1)}");
                    Console.WriteLine($"Difference: {inheritance.Subtract(5.6, 2.1)}");
                    Console.WriteLine($"Product: {inheritance.Multiply(2.2,1.2)}");
                    Console.WriteLine($"Division: {inheritance.Divide(10.4 , 5.2)}");
                    break;

                case 3:
                    AdvancedCalculator calc = new AdvancedCalculator();

                    Console.WriteLine(calc.Add(10, 5));
                    Console.WriteLine(calc.Subtract(10, 5));
                    Console.WriteLine(calc.Multiply(10, 5));
                    Console.WriteLine(calc.Divide(10, 5));
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
            Console.Write("Do you want to continue? (y/n): ");
            string response = Console.ReadLine();
            continueProgram = (response == "y");
        }
    }
}