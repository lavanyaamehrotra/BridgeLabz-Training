using System;
using Microsoft.Data.SqlClient;


public class DoctorService : IDoctorService
{
    public void AddDoctor()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Contact: ");
        string contact = Console.ReadLine();

        Console.Write("Consultation Fee: ");
        decimal fee = decimal.Parse(Console.ReadLine());

        Console.Write("Specialist ID: ");
        int sid = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"INSERT INTO Doctor
                            (name,contact,consultation_fee,specialist_id)
                            VALUES (@name,@contact,@fee,@sid)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@fee", fee);
            cmd.Parameters.AddWithValue("@sid", sid);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Doctor Added Successfully");
        }
    }

    public void UpdateSpecialization()
    {
        Console.Write("Doctor ID: ");
        int did = int.Parse(Console.ReadLine());

        Console.Write("New Specialist ID: ");
        int sid = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Doctor SET specialist_id=@sid WHERE doctor_id=@did",
                    con, tx);

                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@did", did);

                cmd.ExecuteNonQuery();
                tx.Commit();
                Console.WriteLine("Specialty Updated");
            }
            catch
            {
                tx.Rollback();
                Console.WriteLine("Update Failed");
            }
        }
    }

    public void ViewDoctorsBySpecialty()
    {
        Console.Write("Enter Specialty Name: ");
        string name = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT d.name, d.contact
                             FROM Doctor d
                             JOIN Specialization s
                             ON d.specialist_id = s.specialist_id
                             WHERE s.specialist_name = @name";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"Doctor: {dr["name"]}  Contact: {dr["contact"]}");
            }
        }
    }

    public void DeactivateDoctor()
    {
        Console.Write("Doctor ID: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = "UPDATE Doctor SET is_active = 0 WHERE doctor_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine(" Doctor Deactivated");
        }
    }
}
