using System.Net.NetworkInformation;

namespace AuthService2024032.Domain.Constants;

public static class RoleConstants
{
    public const string ADMIN_ROLE = "ADMIN_ROLE";
    public const string USER_ROLE ="USER_ROLE";

    public static readonly string[] AllowedRole = [ADMIN_ROLE, USER_ROLE];
}