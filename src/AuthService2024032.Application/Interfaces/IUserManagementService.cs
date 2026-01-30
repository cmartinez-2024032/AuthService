using AuthService2024032.Application.DTOs;

namespace AuthService2024032.Application.interfaces;

public interface IUserManagementService
{
    Task<UserResponseDto> UpdateUserRoleAsync(string userId, string roleName);
    Task<IReadOnlyList<string>> GetUserRolesAsync(string userID);
    Task<IReadOnlyList<UserResponseDto>> GetUserByRoleAsync(String roleName);
}
