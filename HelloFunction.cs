using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace azure_functions_lab;

public class HelloFunction
{
    private readonly ILogger<HelloFunction> _logger;

    public HelloFunction(ILogger<HelloFunction> logger)
    {
        _logger = logger;
    }

    [Function("HelloFunction")]
    public IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("HelloFunction triggered");

        var name = req.Query["name"];

        if (string.IsNullOrEmpty(name))
        {
            _logger.LogInformation("No name provided");
            return new OkObjectResult("Welcome to Azure Functions!");
        }

        _logger.LogInformation("Name provided: {Name}", name);

        return new OkObjectResult($"Hello, {name}!");
    }
}
