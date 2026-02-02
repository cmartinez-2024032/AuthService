using AuthService2024032.Domain.Entities;
namespace AuthService2024032.Domain.Interface;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyList<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserRoleNAmesAsync(string userId);
    
}