using System;
using Microsoft.Data.SqlClient;

public class VisitService : IVisitService
{
    /* UC-4.1: Record Visit */
    public void RecordVisit()
    {
        Console.Write("Appointment ID: ");
        int appId = int.Parse(Console.ReadLine());

        Console.Write("Diagnosis: ");
        string diagnosis = Console.ReadLine();

        Console.Write("Notes: ");
        string notes = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();

            try
            {
                SqlCommand visitCmd = new SqlCommand(
                    @"INSERT INTO Visit (appointment_id, diagnosis, notes, visit_date)
                      VALUES (@aid,@diag,@notes,GETDATE())",
                    con, tx);

                visitCmd.Parameters.AddWithValue("@aid", appId);
                visitCmd.Parameters.AddWithValue("@diag", diagnosis);
                visitCmd.Parameters.AddWithValue("@notes", notes);
                visitCmd.ExecuteNonQuery();

                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE Appointment SET status='Completed' WHERE appointment_id=@id",
                    con, tx);
                updateCmd.Parameters.AddWithValue("@id", appId);
                updateCmd.ExecuteNonQuery();

                tx.Commit();
                Console.WriteLine(" Visit Recorded");
            }
            catch
            {
                tx.Rollback();
                Console.WriteLine("Failed to Record Visit");
            }
        }
    }

    /* UC-4.2: View Medical History */
    public void ViewMedicalHistory()
    {
        Console.Write("Patient ID: ");
        int pid = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT v.visit_date, v.diagnosis, pr.medicine_name
                             FROM Visit v
                             JOIN Appointment a ON v.appointment_id=a.appointment_id
                             LEFT JOIN Prescription pr ON v.visit_id=pr.visit_id
                             WHERE a.patient_id=@id
                             ORDER BY v.visit_date DESC";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", pid);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr["visit_date"]} | {dr["diagnosis"]} | {dr["medicine_name"]}");
            }
        }
    }

    /* UC-4.3: Add Prescription */
    public void AddPrescription()
    {
        Console.Write("Visit ID: ");
        int visitId = int.Parse(Console.ReadLine());

        Console.Write("Medicine Name: ");
        string med = Console.ReadLine();

        Console.Write("Dosage: ");
        string dosage = Console.ReadLine();

        Console.Write("Duration: ");
        string duration = Console.ReadLine();

        using (SqlConnection con = DBConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Prescription (visit_id, medicine_name, dosage, duration)
                  VALUES (@vid,@med,@dos,@dur)", con);

            cmd.Parameters.AddWithValue("@vid", visitId);
            cmd.Parameters.AddWithValue("@med", med);
            cmd.Parameters.AddWithValue("@dos", dosage);
            cmd.Parameters.AddWithValue("@dur", duration);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Prescription Added");
        }
    }
}
