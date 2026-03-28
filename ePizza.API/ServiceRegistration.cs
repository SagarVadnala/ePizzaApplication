using ePizza.Application;
using ePizza.Infrastructure;

namespace ePizza.API
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();

            return services;
        }
    }
}
