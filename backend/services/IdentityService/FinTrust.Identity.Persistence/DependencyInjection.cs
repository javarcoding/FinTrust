using Microsoft.Extensions.DependencyInjection;

namespace FinTrust.Identity.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services)
    {
        // DbContext
        // Identity
        // Repository
        // Unit Of Work

        return services;
    }
}