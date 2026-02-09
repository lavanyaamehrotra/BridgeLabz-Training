using System;
using Microsoft.Data.SqlClient;


public class PatientService : IPatientService
{
    public void RegisterPatient()
    {
        try
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("DOB (yyyy-mm-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Blood Group: ");
            string bloodGroup = Console.ReadLine();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Patient
                                (name,dob,phone,address,blood_group)
                                VALUES (@name,@dob,@phone,@address,@blood)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@blood", bloodGroup);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Patient Registered Successfully");
            }
        }
        catch (Exception ex)
        {
            throw new HealthCareException(ex.Message);
        }
    }

    public void UpdatePatient()
    {
        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("New Address: ");
        string address = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = "UPDATE Patient SET address=@address WHERE patient_id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? " Patient Updated" : " Patient Not Found");
        }
    }

    public void SearchPatient()
    {
        Console.Write("Enter Name or Phone: ");
        string search = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_SearchPatient", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@search", search);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"ID:{dr["patient_id"]}  Name:{dr["name"]}  Phone:{dr["phone"]}");
            }
        }
    }

    public void ViewPatientHistory()
    {
        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_PatientVisitHistory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@patient_id", id);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("Date | Doctor | Diagnosis");
            while (dr.Read())
            {
                Console.WriteLine($"{dr["visit_date"]} | {dr["doctor_name"]} | {dr["diagnosis"]}");
            }
        }
    }
}
