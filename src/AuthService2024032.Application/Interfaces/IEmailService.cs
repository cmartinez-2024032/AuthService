namespace AuthService2024032.Application.interfaces;

public interface IEmailService
{
    Task SendEmailVerificationAsync(string email, string username, string token);
    Task SendPasswordResetAsync(string email, string username, string token);
    Task SendWelcomeEmailAsync(string email, string username);
    
}