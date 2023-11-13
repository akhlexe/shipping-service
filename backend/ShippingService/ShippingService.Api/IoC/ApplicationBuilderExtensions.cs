using ShippingService.Api.Utilities;

namespace ShippingService.Api.IoC
{
    public static class ApplicationBuilderExtensions
    {
        public static WebApplication InitializeDatabase(this WebApplication app)
        {
            PrepDB.Migrate(app);
            return app;
        }

        public static WebApplication AddSwaggerInDevelopment(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            return app;
        }

        public static WebApplication AddHttpsRedirection(this WebApplication app)
        {
            app.UseHttpsRedirection();
            return app;
        }

        public static WebApplication AddAuthorization(this WebApplication app)
        {
            app.UseAuthorization();
            return app;
        }

        public static WebApplication AddControllers(this WebApplication app)
        {
            app.MapControllers();
            return app;
        }
    }
}
