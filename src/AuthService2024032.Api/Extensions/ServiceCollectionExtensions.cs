using AuthService2024032.Domain.interfaces;
using AuthService2024032.Persistence.Data;
using AuthService2024032.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using AuthService2024032.Application.interfaces;

namespace AuthService2024032.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Configuración de DbContext con Npgsql y convención snake_case
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                   .UseSnakeCaseNamingConvention());

        // Inyección de repositorios
        services.AddScoped<UserRepository, UserRepository>();
        services.AddScoped<RoleRepository, RoleRepository>();

        // Health checks
        services.AddHealthChecks();

        return services;
    }

    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        // Configuración de documentación Swagger
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}
