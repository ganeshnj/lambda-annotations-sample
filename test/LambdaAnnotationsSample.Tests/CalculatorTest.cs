using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;

using LambdaAnnotationsSample;

namespace LambdaAnnotationsSample.Tests
{
    public class CalculatorTest
    {
        private readonly CalculatorService calculatorService;
        private readonly Calculator calculator;

        public CalculatorTest()
        {
            calculatorService = new CalculatorService();
            calculator = new Calculator(calculatorService);
        }

        [Fact]
        public void Calculator_Add()
        { 
            Assert.Equal(3, calculator.Add(1,2));
        }

        [Fact]
        public void Calculator_Subtract()
        {
            Assert.Equal(-1, calculator.Subtract(1, 2, calculatorService));
        }
    }
}
