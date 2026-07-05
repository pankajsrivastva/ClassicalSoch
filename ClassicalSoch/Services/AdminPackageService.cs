using ClassicalSoch.Interfaces;
using ClassicalSoch.Models;
using ClassicalSoch.Repositories;

namespace ClassicalSoch.Services;

public class AdminPackageService : IAdminPackageService
{
    public Task<List<Package>> GetPackagesAsync(string? category = null, string? search = null)
    {
        var packages = StaticDataStore.GetPackages(category, search);
        return Task.FromResult(packages);
    }

    public Task<bool> CreatePackageAsync(Package package)
    {
        var created = StaticDataStore.AddPackage(package);
        return Task.FromResult(created);
    }
}