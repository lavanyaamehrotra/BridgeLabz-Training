using ContactsApp.Database;
using ContactsApp.Models;
using Microsoft.Data.SqlClient;

namespace ContactsApp.Repositories;
public class ContactRepository : IContactRepository
{
    private readonly DbConnection _factory;

    public ContactRepository(DbConnection factory)
    {
        _factory = factory;
    }

    public List<Contact> GetAll()
    {
        List<Contact> contacts = new();
        using SqlConnection connection = _factory.CreateConnection();
        connection.Open();
        string query = "SELECT * FROM Contacts";
        SqlCommand command = new(query, connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            contacts.Add(new Contact
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()!,
                Email = reader["Email"].ToString()!,
                Phone = reader["Phone"].ToString()!
            });
        }
        return contacts;
    }

    public Contact? GetById(int id)
    {
        using SqlConnection connection = _factory.CreateConnection();
        connection.Open();
        string query = "SELECT * FROM Contacts WHERE Id=@Id";
        SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@Id", id);
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            return new Contact
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()!,
                Email = reader["Email"].ToString()!,
                Phone = reader["Phone"].ToString()!
            };
        }
        return null;
    }

    public void Add(Contact contact)
    {
        using SqlConnection connection = _factory.CreateConnection();
        connection.Open();
        string query = @"INSERT INTO Contacts(Name,Email,Phone)
                         VALUES(@Name,@Email,@Phone)";
        SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@Name", contact.Name);
        command.Parameters.AddWithValue("@Email", contact.Email);
        command.Parameters.AddWithValue("@Phone", contact.Phone);
        command.ExecuteNonQuery();
    }

    public void Update(Contact contact)
    {
        using SqlConnection connection = _factory.CreateConnection();
        connection.Open();
        string query = @"UPDATE Contacts
                         SET Name=@Name,
                             Email=@Email,
                             Phone=@Phone
                         WHERE Id=@Id";
        SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@Id", contact.Id);
        command.Parameters.AddWithValue("@Name", contact.Name);
        command.Parameters.AddWithValue("@Email", contact.Email);
        command.Parameters.AddWithValue("@Phone", contact.Phone);
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using SqlConnection connection = _factory.CreateConnection();
        connection.Open();
        string query = "DELETE FROM Contacts WHERE Id=@Id";
        SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@Id", id);
        command.ExecuteNonQuery();
    }
}