using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
        public class Primenum
        {
            public bool Isprime(int x)
            {
                if (x < 2)
                {
                    return false;
                }

                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        return false;

                    }
                }
                return true;
            }
        }
    }
