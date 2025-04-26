using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Function_overloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Muliply(int a, int b)
        {
            return a * b;
        }

        public double Muliply(double a, double b)
        {
            return a * b;
        }

    }
}
