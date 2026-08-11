using Microsoft.Data.SqlClient;

namespace ContactsApp.Database;

public class DbConnection
{
    private readonly string _connectionString;
    public DbConnection(IConfiguration configuration)
    {
        _connectionString =configuration.GetConnectionString("DefaultConnection")!;
    }
    public SqlConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}