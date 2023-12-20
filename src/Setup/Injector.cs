using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Setup;

public static class Injector
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}