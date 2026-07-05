namespace ClassicalSoch.Interfaces;

public interface IAdminAuthService
{
    Task<bool> ValidateAdminAsync(string username, string password);
}
