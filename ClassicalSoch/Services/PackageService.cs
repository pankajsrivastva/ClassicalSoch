using ClassicalSoch.Interfaces;
using ClassicalSoch.Models;
using ClassicalSoch.Repositories;

namespace ClassicalSoch.Services;

public class PackageService : IPackageService
{
    public Task<List<Package>> GetPackagesAsync(string? category = null, string? search = null)
    {
        var packages = StaticDataStore.GetPackages(category, search);
        return Task.FromResult(packages);
    }
}