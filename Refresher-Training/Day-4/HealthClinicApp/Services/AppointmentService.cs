using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;
using HealthClinicApp.Interfaces;
namespace HealthClinicApp.Services;
public class AppointmentService : IAppointmentService{
    DatabaseConnection db = new DatabaseConnection();
    //====================================================
    // ADD APPOINTMENT
    //====================================================
    public void AddAppointment(){
        try{
            Console.Write("Appointment Date (yyyy-mm-dd) : ");
            DateTime appointmentDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Appointment Time (HH:mm) : ");
            TimeSpan appointmentTime = TimeSpan.Parse(Console.ReadLine()!);
            Console.Write("Visit Type : ");
            string visitType = Console.ReadLine()!;
            Console.Write("Appointment Status : ");
            string appointmentStatus = Console.ReadLine()!;
            Console.Write("Doctor ID : ");
            int doctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient ID : ");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Appointment appointment = new Appointment(0,appointmentDate, appointmentTime, visitType, appointmentStatus, doctorId, patientId);

            using SqlConnection connection = db.GetConnection();

            string query = @"INSERT INTO Appointment
                            (AppointmentDate,AppointmentTime,VisitType,AppointmentStatus,DoctorID,PatientID)
                            VALUES
                            (@AppointmentDate,@AppointmentTime,@VisitType,@AppointmentStatus,@DoctorID,@PatientID)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
            cmd.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
            cmd.Parameters.AddWithValue("@VisitType", appointment.VisitType);
            cmd.Parameters.AddWithValue("@AppointmentStatus", appointment.AppointmentStatus);
            cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
            cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);

            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
                Console.WriteLine("\nAppointment Added Successfully.");
            else
                Console.WriteLine("\nAppointment Not Added.");
        }
        catch(SqlException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    //====================================================
    // VIEW APPOINTMENTS
    //====================================================
    public void ViewAppointments(){
        try{
            using SqlConnection connection = db.GetConnection();

            string query = @"SELECT
                            A.AppointmentID,
                            A.AppointmentDate,
                            A.AppointmentTime,
                            A.VisitType,
                            A.AppointmentStatus,
                            D.DoctorName,
                            P.PatientName
                            FROM Appointment A
                            INNER JOIN Doctor D
                            ON A.DoctorID=D.DoctorID
                            INNER JOIN Patient P
                            ON A.PatientID=P.PatientID";

            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Appointment ID : {reader["AppointmentID"]}");
                Console.WriteLine($"Date           : {Convert.ToDateTime(reader["AppointmentDate"]).ToShortDateString()}");
                Console.WriteLine($"Time           : {reader["AppointmentTime"]}");
                Console.WriteLine($"Visit Type     : {reader["VisitType"]}");
                Console.WriteLine($"Status         : {reader["AppointmentStatus"]}");
                Console.WriteLine($"Doctor Name    : {reader["DoctorName"]}");
                Console.WriteLine($"Patient Name   : {reader["PatientName"]}");
            }

            reader.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // SEARCH APPOINTMENT
    //====================================================

    public void SearchAppointment(){
        try{
            Console.Write("Enter Appointment ID : ");
            int appointmentId = Convert.ToInt32(Console.ReadLine());
            using SqlConnection connection = db.GetConnection();
            string query = "SELECT * FROM Appointment WHERE AppointmentID=@AppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()){
                Console.WriteLine($"Appointment ID : {reader["AppointmentID"]}");
                Console.WriteLine($"Date           : {reader["AppointmentDate"]}");
                Console.WriteLine($"Time           : {reader["AppointmentTime"]}");
                Console.WriteLine($"Visit Type     : {reader["VisitType"]}");
                Console.WriteLine($"Status         : {reader["AppointmentStatus"]}");
                Console.WriteLine($"Doctor ID      : {reader["DoctorID"]}");
                Console.WriteLine($"Patient ID     : {reader["PatientID"]}");
            }else{
                Console.WriteLine("Appointment Not Found.");
            }

            reader.Close();
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
        //====================================================
    // UPDATE APPOINTMENT
    //====================================================

    public void UpdateAppointment()
    {
        try
        {
            Console.Write("Enter Appointment ID : ");
            int appointmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Appointment Date");
            Console.WriteLine("2. Appointment Time");
            Console.WriteLine("3. Appointment Status");
            Console.Write("Enter Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            connection.Open();

            SqlCommand cmd;

            switch(choice)
            {
                case 1:

                    Console.Write("Enter New Date (yyyy-mm-dd) : ");
                    DateTime appointmentDate = Convert.ToDateTime(Console.ReadLine());

                    cmd = new SqlCommand(@"UPDATE Appointment SET AppointmentDate=@AppointmentDate WHERE AppointmentID=@AppointmentID", connection);

                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    break;

                case 2:

                    Console.Write("Enter New Time (HH:mm) : ");
                    TimeSpan appointmentTime = TimeSpan.Parse(Console.ReadLine()!);

                    cmd = new SqlCommand(@"UPDATE Appointment SET AppointmentTime=@AppointmentTime WHERE AppointmentID=@AppointmentID", connection);

                    cmd.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    break;

                case 3:

                    Console.Write("Enter New Status : ");
                    string status = Console.ReadLine()!;

                    cmd = new SqlCommand(@"UPDATE Appointment SET AppointmentStatus=@AppointmentStatus WHERE AppointmentID=@AppointmentID", connection);

                    cmd.Parameters.AddWithValue("@AppointmentStatus", status);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    break;

                default:

                    Console.WriteLine("Invalid Choice.");
                    return;
            }

            int rows = cmd.ExecuteNonQuery();

            if(rows > 0)
                Console.WriteLine("\nAppointment Updated Successfully.");
            else
                Console.WriteLine("\nAppointment Not Found.");
        }
        catch(SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // DELETE APPOINTMENT
    //====================================================

    public void DeleteAppointment()
    {
        try
        {
            Console.Write("Enter Appointment ID : ");

            int appointmentId = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            string query = "DELETE FROM Appointment WHERE AppointmentID=@AppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

            connection.Open();

            int rows = cmd.ExecuteNonQuery();

            if(rows > 0)
                Console.WriteLine("\nAppointment Deleted Successfully.");
            else
                Console.WriteLine("\nAppointment Not Found.");
        }
        catch(SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}