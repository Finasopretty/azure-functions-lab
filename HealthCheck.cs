using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace azure_functions_lab;

public class HealthCheck
{
    private readonly ILogger<HealthCheck> _logger;

    public HealthCheck(ILogger<HealthCheck> logger)
    {
        _logger = logger;
    }

    [Function("HealthCheck")]
    public HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
    {
        _logger.LogInformation("Health check requested.");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteString("Healthy");

        return response;
    }
}
