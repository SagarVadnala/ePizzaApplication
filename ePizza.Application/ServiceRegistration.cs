using ePizza.Application.Contracts;
using ePizza.Application.Implemen;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IItemService,ItemService>();

            return services;
        }
    }
}
