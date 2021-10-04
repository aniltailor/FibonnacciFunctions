using System.IO;
using System.Threading.Tasks;
using FibonacciService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FibonacciFunctionsByAnilTailor
{
    public class FindInFibonacci
    {
        private readonly IFindInFibonacciService _service;

        public FindInFibonacci(IFindInFibonacciService service)
        {
            _service = service;
        }

        [FunctionName("FindInFibonacci")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "v1/FindInFibonacci/{integerForSearch}")] HttpRequest req, string integerForSearch, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function FindInFibonacci processed a request.");

            var responseMessage = _service.FindFibonacciNumbers(integerForSearch);

            return new OkObjectResult(responseMessage);
        }
    }
}
