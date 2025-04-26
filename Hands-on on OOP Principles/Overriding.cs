using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Base class
    internal class BasicCalculator
    {
        public virtual int Add(int a, int b)
        {
            return a + b;
        }

        public virtual int Subtract(int a, int b)
        {
            return a - b;
        }

        public virtual int Multiply(int a, int b)
        {
            return a * b;
        }

        public virtual double Divide(int a, int b)
        {
            if (b != 0)
                return (double)a / b;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }

    // Derived class overriding methods
    internal class AdvancedCalculator : BasicCalculator
    {
        public override int Add(int a, int b)
        {
            Console.WriteLine("Using AdvancedCalculator Add:");
            return base.Add(a, b);
        }

        public override int Subtract(int a, int b)
        {
            Console.WriteLine("Using AdvancedCalculator Subtract:");
            return base.Subtract(a, b);
        }

        public override int Multiply(int a, int b)
        {
            Console.WriteLine("Using AdvancedCalculator Multiply:");
            return base.Multiply(a, b);
        }

        public override double Divide(int a, int b)
        {
            Console.WriteLine("Using AdvancedCalculator Divide:");
            return base.Divide(a, b);
        }
    }
}
