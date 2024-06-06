using FoodDelivery.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace FoodDelivery.Application;

public static class DependencyInjectioin
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
    }
}