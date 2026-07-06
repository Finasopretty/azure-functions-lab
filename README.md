# ⚡ Azure Functions (.NET 8) — Serverless HTTP API

A serverless HTTP API built using **Azure Functions (.NET 8 Isolated Worker Model)** and deployed via **GitHub Actions CI/CD**.

---

## 🌐 Live API (Azure Deployment)

> Replace this with your own Function App URL if redeployed.

**Base URL**

https://<your-function-app>.azurewebsites.net


**Endpoint**

GET /api/HelloFunction


### Example Request
```bash
curl https://<your-function-app>.azurewebsites.net/api/HelloFunction
Example Response
Welcome to Azure Functions!
🚀 Overview

This project demonstrates a simple serverless API using Azure Functions with automated deployment through GitHub Actions.

Features:

HTTP-triggered Azure Function
.NET 8 isolated worker model
GitHub Actions CI/CD pipeline
Azure Function App deployment
🧱 Architecture
GitHub Repository
   ↓
GitHub Actions (Build + Publish)
   ↓
Azure Function App
   ↓
HTTP Trigger (/api/HelloFunction)
   ↓
Response returned to client
🛠 Tech Stack
.NET 8
Azure Functions v4
C#
GitHub Actions (CI/CD)
Azure App Service (Function App hosting)
📁 Project Structure
azure-functions-lab/
├── HelloFunction.cs
├── Program.cs
├── host.json
├── local.settings.json
├── azure-functions-lab.csproj
└── .github/workflows/
⚙️ Local Development
Requirements
.NET 8 SDK
Azure Functions Core Tools v4
Run locally
func start
Local endpoint
http://localhost:7071/api/HelloFunction
🔧 Function Code
[Function("HelloFunction")]
public IActionResult Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
{
    return new OkObjectResult("Welcome to Azure Functions!");
}
🚀 Deployment

Deployed automatically using GitHub Actions.

Key step:

dotnet publish -c Release -o ./publish
⚠️ Common Issues

401 Unauthorized

Function requires key → set AuthorizationLevel.Anonymous

404 Not Found

Wrong route or deployment mismatch

500 Error

Runtime or dependency issue in Function App
🧠 Learning Outcomes
Azure Functions deployment pipeline
GitHub Actions CI/CD integration
HTTP-trigger serverless APIs
.NET 8 isolated worker model
👤 Author

Learning project for Azure serverless architecture and CI/CD automation.
