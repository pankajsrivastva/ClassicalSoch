using ClassicalSoch.Models;

namespace ClassicalSoch.Interfaces;

public interface IPackageService
{
    Task<List<Package>> GetPackagesAsync(string? category = null, string? search = null);
}
