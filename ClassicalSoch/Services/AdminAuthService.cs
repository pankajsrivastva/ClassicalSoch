using System.Security.Cryptography;
using System.Text;
using ClassicalSoch.Interfaces;

namespace ClassicalSoch.Services;

public class AdminAuthService : IAdminAuthService
{
    public Task<bool> ValidateAdminAsync(string username, string password)
    {
       // var storedHash = "$2a$12$2gV/pV0f2ptFs3R2Sxw9M.Lg5I8AbJ8v6P2YQ6R1Fqg9m3Z5D9wW2";
        var storedHash = "admin@123";
        var valid = username.Equals("admin", StringComparison.OrdinalIgnoreCase) && VerifyPassword(password, storedHash);
        return Task.FromResult(valid);
    }

    private static bool VerifyPassword(string password, string storedHash)
    {
        try
        {
            //return BCrypt.Net.BCrypt.Verify(password, storedHash);
            return password == storedHash;
        }
        catch
        {
            return false;
        }
    }
}
