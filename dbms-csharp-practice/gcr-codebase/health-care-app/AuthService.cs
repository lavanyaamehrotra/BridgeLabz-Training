using Microsoft.Data.SqlClient;

public class AuthService
{
    public string Login(string username, string password)
    {
        using SqlConnection con = DBConnection.GetConnection();

        SqlCommand cmd = new SqlCommand("sp_LoginUser", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);

        con.Open();
        object role = cmd.ExecuteScalar();

        return role == null ? null : role.ToString();
    }
}
