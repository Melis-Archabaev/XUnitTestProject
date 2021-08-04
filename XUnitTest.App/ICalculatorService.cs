using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest.App
{
    public interface ICalculatorService
    {
        public int Add(int a, int b);
        public int Multiple(int a, int b);
        public int Division(int a, int b);
        public int Minus(int a, int b);

    }

}
