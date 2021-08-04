using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest.App
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a + b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Multiple(int a, int b)
        {
            return a * b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
