namespace ClassicalSoch.Models;

public class AdminPackageViewModel
{
    public List<Package> Packages { get; set; } = new();
    public string? Category { get; set; }
    public string? Search { get; set; }
}
