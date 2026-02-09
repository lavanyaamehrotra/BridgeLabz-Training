using System;
using Microsoft.Data.SqlClient;

public class AppointmentService : IAppointmentService
{
    /* UC-3.1: Book Appointment */
    public void BookAppointment()
    {
        Console.Write("Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());

        Console.Write("Doctor ID: ");
        int doctorId = int.Parse(Console.ReadLine());

        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Time (HH:mm): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string checkQuery = @"SELECT COUNT(*) FROM Appointment
                                  WHERE doctor_id=@doc AND appointment_date=@date
                                  AND appointment_time=@time AND status='Scheduled'";

            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@doc", doctorId);
            checkCmd.Parameters.AddWithValue("@date", date);
            checkCmd.Parameters.AddWithValue("@time", time);

            con.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                Console.WriteLine("Slot not available");
                return;
            }

            string insertQuery = @"INSERT INTO Appointment
                                  (patient_id, doctor_id, appointment_date, appointment_time, status)
                                  VALUES (@pid,@did,@date,@time,'Scheduled')";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@did", doctorId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);

            cmd.ExecuteNonQuery();
            Console.WriteLine("✅ Appointment Booked");
        }
    }

    /* UC-3.2: Check Doctor Availability */
    public void CheckDoctorAvailability()
    {
        Console.Write("Doctor ID: ");
        int doctorId = int.Parse(Console.ReadLine());

        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT appointment_time, COUNT(*) AS total
                             FROM Appointment
                             WHERE doctor_id=@id AND appointment_date=@date
                             GROUP BY appointment_time";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", doctorId);
            cmd.Parameters.AddWithValue("@date", date);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("Time | Bookings");
            while (dr.Read())
            {
                Console.WriteLine($"{dr["appointment_time"]} | {dr["total"]}");
            }
        }
    }

    /* UC-3.3: Cancel Appointment (with transaction) */
    public void CancelAppointment()
    {
        Console.Write("Appointment ID: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();

            try
            {
                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE Appointment SET status='Cancelled' WHERE appointment_id=@id",
                    con, tx);
                updateCmd.Parameters.AddWithValue("@id", id);
                updateCmd.ExecuteNonQuery();

                SqlCommand auditCmd = new SqlCommand(
                    "INSERT INTO Appointment_Audit (appointment_id, action) VALUES (@id,'Cancelled')",
                    con, tx);
                auditCmd.Parameters.AddWithValue("@id", id);
                auditCmd.ExecuteNonQuery();

                tx.Commit();
                Console.WriteLine("Appointment Cancelled");
            }
            catch
            {
                tx.Rollback();
                Console.WriteLine("Cancellation Failed");
            }
        }
    }

    /* UC-3.4: Reschedule Appointment */
    public void RescheduleAppointment()
    {
        Console.Write("Appointment ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("New Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("New Time (HH:mm): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Appointment
                      SET appointment_date=@date, appointment_time=@time
                      WHERE appointment_id=@id",
                    con, tx);

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                tx.Commit();
                Console.WriteLine("Appointment Rescheduled");
            }
            catch
            {
                tx.Rollback();
                Console.WriteLine("Conflict Detected");
            }
        }
    }

    /* UC-3.5: View Daily Schedule */
    public void ViewDailySchedule()
    {
        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        using (SqlConnection con = DBConnection.GetConnection())
        {
            string query = @"SELECT a.appointment_time, p.name AS patient, d.name AS doctor
                             FROM Appointment a
                             JOIN Patient p ON a.patient_id=p.patient_id
                             JOIN Doctor d ON a.doctor_id=d.doctor_id
                             WHERE a.appointment_date=@date
                             ORDER BY a.appointment_time";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date", date);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr["appointment_time"]} | {dr["patient"]} | {dr["doctor"]}");
            }
        }
    }
}
