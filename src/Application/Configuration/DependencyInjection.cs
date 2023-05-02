using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace MediatR.Pipelines.Application.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(x =>
            x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}