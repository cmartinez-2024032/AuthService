using System.ComponentModel.DataAnnotations;

namespace AuthService2024032.Application.Application.DTOs.Email;

public class ResendVerificationDto
{
    [Required]
    [EmailAddress]

    public string Email {get; set;} = string.Empty;
}