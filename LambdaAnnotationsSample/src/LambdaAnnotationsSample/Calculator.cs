using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Annotations;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaAnnotationsSample
{
    public class Calculator
    {
        private readonly CalculatorService calculatorService;

        public Calculator(CalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        [LambdaFunction(Name = "CalculatorAdd", PackageType = LambdaPackageType.Image)]
        [RestApi(HttpMethod.Get, "/Calculator/Add/{x}/{y}")]
        public int Add(int x, int y)
        {
            return calculatorService.Add(x, y);
        }

        [LambdaFunction(Name = "CalculatorSubtract", PackageType = LambdaPackageType.Image)]
        [RestApi(HttpMethod.Get, "/Calculator/Subtract")]
        public int Subtract([FromQuery]int x, [FromQuery]int y, [FromServices]CalculatorService calculatorService)
        {
            return calculatorService.Substract(x, y);
        }
    }
}
