using Microsoft.Data.SqlClient;


public class DBConnection
{
    private static string connectionString ="Server=localhost\\SQLEXPRESS;Database=HealthCare;Trusted_Connection=True;TrustServerCertificate=True;";
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
