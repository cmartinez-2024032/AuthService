using AuthService2024032.Domain.Entities;

namespace AuthService2024032.Application.interfaces;

public interface IJwtTokenService
{
    string GenerateToken (User user);
    
}