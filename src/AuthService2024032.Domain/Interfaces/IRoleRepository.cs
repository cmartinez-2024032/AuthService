using AuthService2024032.Domain.Entities;
namespace AuthService2024032.Domain.Entities;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyCollection<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyCollection<string>> GetUserRoleNAmesAsync(string userId);
    
}