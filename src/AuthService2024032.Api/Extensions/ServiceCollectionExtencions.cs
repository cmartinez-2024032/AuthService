using AuthService2024032.Domain.Interface;
using AuthService2024032.Persistence.Data;
using AuthService2024032.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using AuthService2024032.Application.Interface;
namespace AuthService2024032.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UserNpgsql(configuration.GetConnecionString("DefaultConnection"))
            .UseSnakeCaseNamingConvention());

        Services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRespository, RoleRespository>();

        services.AddHealthChecks();

        return services;
    }

    public static IServiceCollection AddApiDocumenttation(this IServiceCollection services)
    {
        services.AddEndPointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
    
}