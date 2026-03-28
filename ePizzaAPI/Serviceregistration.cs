using ePizza.Application;
using ePizza.Infrastructure;

namespace ePizzaAPI
{
    public static class Serviceregistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();

            return services;
        }

    }
}
