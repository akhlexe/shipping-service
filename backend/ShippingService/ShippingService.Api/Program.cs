using ShippingService.Api;
using ShippingService.Api.Utilities;
using ShippingService.Infrastructure;
using ShippingService.Infrastructure.Persistence.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();

var app = builder.Build();

PrepDB.Migrate(app);
DataSeeder.SeedData(app.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
