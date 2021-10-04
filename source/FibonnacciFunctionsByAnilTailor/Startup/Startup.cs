using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using FibonacciFunctionsByAnilTailor.Startup;
using FibonacciService;
using Microsoft.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(Startup))]

namespace FibonacciFunctionsByAnilTailor.Startup
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder);
        }

        private void ConfigureServices(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging();
            builder.Services.AddScoped<IFindInFibonacciService, FindInFibonacciService>();
        }
    }
}