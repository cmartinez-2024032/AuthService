using AuthService2024032.Application.interfaces;
using Konscious.Security.Cryptography;
using System.Security.Cryptography;
using System.Text;

namespace AuthService2024003.Application.Services;

public class PasswordHashService : IPasswordHashService
{


    private const int SaltSize = 16;
    private const int HashSize = 32;
    private const int Iterations = 2;
    private const int Memory = 102400;
    private const int Parallelism = 8;
    public string HashPassword(string password)
    {
        
    }

    public bool VerifyPassword(string password, string HashPassword)
}