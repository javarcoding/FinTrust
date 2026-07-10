using Microsoft.Extensions.DependencyInjection;

namespace FinTrust.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        // Email Service
        // JWT Service
        // Encryption
        // Logging

        return services;
    }
}