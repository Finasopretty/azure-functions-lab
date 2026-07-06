using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace azure_functions_lab;

public class GetUsers
{
    private readonly ILogger<GetUsers> _logger;

    public GetUsers(ILogger<GetUsers> logger)
    {
        _logger = logger;
    }

    [Function("GetUsers")]
    public HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
    {
        _logger.LogInformation("GetUsers endpoint called.");

        var users = new[]
        {
            new { Id = 1, Name = "Alice", Role = "Administrator" },
            new { Id = 2, Name = "Bob", Role = "Developer" },
            new { Id = 3, Name = "Charlie", Role = "Support" }
        };

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteAsJsonAsync(users).GetAwaiter().GetResult();

        return response;
    }
}