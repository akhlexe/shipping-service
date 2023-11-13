﻿using ShippingService.Application;

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
                config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
                config.RegisterServicesFromAssemblies(typeof(ApplicationAssemblyMarkerType).Assembly);
            });

            return services;
        }
    }
}