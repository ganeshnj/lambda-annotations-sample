using Amazon.Lambda.Annotations;
using Microsoft.Extensions.DependencyInjection;

namespace LambdaAnnotationsSample
{
    [LambdaStartup]
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICalculatorService, CalculatorService>();
        }
    }
}
