using System.ComponentModel.DataAnnotations;

namespace AuthService2024032.Application.DTOs.Email;

public class ForgotPasswordFto
{
    [Required]
    [EmailAddress]
    public string Email { get; set;} = string.Empty;
}