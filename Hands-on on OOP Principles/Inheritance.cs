using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    interface IAddition
    {
        double Add(double a, double b);

    }

    interface ISubtraction
    {
        double Subtract(double a, double b);

    }

    interface IMultiplication
    {
        double Multiply(double a, double b);

    }

    interface Idivision
    {
        double Divide(double a, double b);

    }

    internal class Inheritance : IAddition, ISubtraction, IMultiplication, Idivision
    {
        public double Add(double a, double b)
        {
            return (a + b);

        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }
    }
}
