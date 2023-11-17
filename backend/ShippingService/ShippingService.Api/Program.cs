using ShippingService.Api.IoC;
using ShippingService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfrastructureServices(builder.Configuration)
    .AddMediatRService()
    .AddCustomCors()
    .AddApiServices();

var app = builder.Build();

app.InitializeDatabase()
    .AddSwaggerInDevelopment()
    .AddHttpsRedirection()
    .AddAuthorization()
    .AddControllers()
    .UseCors()
    .Run();