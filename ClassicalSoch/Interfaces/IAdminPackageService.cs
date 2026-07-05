using ClassicalSoch.Models;

namespace ClassicalSoch.Interfaces;

public interface IAdminPackageService
{
    Task<List<Package>> GetPackagesAsync(string? category = null, string? search = null);
    Task<bool> CreatePackageAsync(Package package);
}
