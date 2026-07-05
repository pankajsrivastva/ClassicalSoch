using System.Data;
using Npgsql;

namespace ClassicalSoch.Repositories;

public class DbConnectionFactory
{
    private readonly IConfiguration _configuration;

    public DbConnectionFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public NpgsqlConnection CreateConnection()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection") ?? "Host=localhost;Port=5432;Database=classicalsoch;Username=postgres;Password=postgres";
        return new NpgsqlConnection(connectionString);
    }
}
