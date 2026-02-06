using AuthService2024032.Domain.Entities;

namespace AuthService2024032.Domain.interfaces;
public interface IUserRepository
{
    Task<User> CreateAsync(User user);
    Task<User> GetUserAsync(string id);
    Task<User?> GetByUserAsync(string email);
    Task<User?> GetByUsernameAsync(string username);
    Task<User?> GetByEmailVerofocationTokenAsync(string token);
    Task<User?> GetByPasswordResetTokenAsync(string token);
    Task<bool> ExistsByEmailAsync(string email);
    Task<bool> ExistByUsernameAsync(string username);
    Task<User> UpdateAsync(User user);
    Task<bool> DeleteAsync(string id);
    Task UpdateUserRoleAsync(string userId, string roleId);
    

}