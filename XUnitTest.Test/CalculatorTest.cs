using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTest.App;

namespace XUnitTest.Test
{
    public class CalculatorTest
    {
        public Calculator _calculator { get; set; }
        public Mock<ICalculatorService> myMock { get; set; }
        public CalculatorTest()
        {
            myMock = new Mock<ICalculatorService>();
            this._calculator = new Calculator(myMock.Object);
            //this._calculator = new Calculator(new CalculatorService());
        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(10, 2, 12)]
        public void Add_SimpleValues_ReturnTotalValue(int a, int b, int expectedTotal)
        {
            
            myMock.Setup(x => x.Add(a, b)).Returns(expectedTotal);

            var actualTotal = _calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);

            myMock.Verify(x => x.Add(a, b), Times.AtLeast(2)); 
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(10, 0, 0)]
        public void Add_ZeroValues_ReturnZeroValue(int a, int b, int expectedTotal)
        {
            var actualTotal = _calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }
        [Theory]
        [InlineData(10,2,5)]
        public void Division_SimpleValues_ReturnValueOfDivision(int a, int b, int expectedTotal)
        {
            myMock.Setup(x => x.Division(a, b)).Returns(expectedTotal);

            Assert.Equal(5,_calculator.Divisioner(a,b));
        }
        [Theory]
        [InlineData(2,4,8)]
        public void Multiple_SimpleValue_ReturnMultipValue(int a, int b,int expectedValue)
        {
            myMock.Setup(x => x.Multiple(a, b)).Returns(expectedValue);

            var actualValue = _calculator.Multipler(a, b);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
