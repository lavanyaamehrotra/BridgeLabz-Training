using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services;

public class DatabaseConnection
{
    private readonly string connectionString =
"Server=LocalHost\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";
    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}