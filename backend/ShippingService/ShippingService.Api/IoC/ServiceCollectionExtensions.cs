using Microsoft.Extensions.DependencyInjection;
using ShippingService.Application;
using ShippingService.Application.ShipmentOrders.Queries.GetShipmentOrders;
using System.Reflection;

namespace ShippingService.Api.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static IServiceCollection AddMediatRService(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies(typeof(Program).Assembly, typeof(ApplicationAssemblyMarker).Assembly);
            });

            return services;
        }

        public static IServiceCollection AddCustomCors(this IServiceCollection services)
        {
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options =>
                {
                    options.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program).Assembly, typeof(ApplicationAssemblyMarker).Assembly);
            return services;
        }
    }
}
