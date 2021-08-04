using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest.App
{
    public class Calculator
    {
        private ICalculatorService _calculatoreService;
        public Calculator(ICalculatorService calculatoreService)
        {
            this._calculatoreService = calculatoreService;
        }

        public int Add(int a, int b)
        {
            
            return _calculatoreService.Add(a, b);
        }
        public int Multipler(int a, int b)
        {
            return _calculatoreService.Multiple(a, b);
        }
        public int Divisioner(int a, int b)
        {
            return _calculatoreService.Division(a, b);
        }
    }
}
