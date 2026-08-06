using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Exceptions;

namespace HealthClinicApp.Services;

public class DoctorService : IDoctorService{
    DatabaseConnection db = new DatabaseConnection();

    //---------------------------------ADD DOCTOR---------------------------------------
        public void AddDoctor()
        {
            try
            {
                Console.Write("Doctor Name : ");
                string doctorName = Console.ReadLine()!;

                Console.Write("Specialization : ");
                string specialization = Console.ReadLine()!;

                Console.Write("Qualification : ");
                string qualification = Console.ReadLine()!;

                Console.Write("Experience : ");
                int experience = Convert.ToInt32(Console.ReadLine());

                Console.Write("Phone Number : ");
                string phoneNumber = Console.ReadLine()!;

                Console.Write("Email : ");
                string email = Console.ReadLine()!;

                Console.Write("Room ID : ");
                int roomId = Convert.ToInt32(Console.ReadLine());

                Doctor doctor = new Doctor(0, doctorName, specialization, qualification, experience, phoneNumber, email, roomId);

                using SqlConnection connection = db.GetConnection();

                SqlCommand cmd = new SqlCommand("sp_AddDoctor", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                cmd.Parameters.AddWithValue("@Qualification", doctor.Qualification);
                cmd.Parameters.AddWithValue("@Experience", doctor.Experience);
                cmd.Parameters.AddWithValue("@PhoneNumber", doctor.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", doctor.Email);
                cmd.Parameters.AddWithValue("@RoomID", doctor.RoomID);

                connection.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("\nDoctor Added Successfully.");
                else
                    Console.WriteLine("\nDoctor Not Added.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    // ---------------------------VIEW DOCTOR----------------------------------
        public void ViewDoctors(){
        try
        {
            using SqlConnection connection = db.GetConnection();
            string query = "SELECT * FROM Doctor";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine();
            while(reader.Read())
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Doctor ID      : {reader["DoctorID"]}");
                Console.WriteLine($"Name           : {reader["DoctorName"]}");
                Console.WriteLine($"Specialization : {reader["Specialization"]}");
                Console.WriteLine($"Qualification  : {reader["Qualification"]}");
                Console.WriteLine($"Experience     : {reader["Experience"]}");
                Console.WriteLine($"Phone Number   : {reader["PhoneNumber"]}");
                Console.WriteLine($"Email          : {reader["Email"]}");
                Console.WriteLine($"Room ID        : {reader["RoomID"]}");
            }
            reader.Close();
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    //---------------------SEARCH DOCTOR---------------------------
        public void SearchDoctor(){
        try{
            Console.Write("Enter Doctor ID : ");
            int doctorId = Convert.ToInt32(Console.ReadLine());
            using SqlConnection connection = db.GetConnection();
            string query = "SELECT * FROM Doctor WHERE DoctorID=@DoctorID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DoctorID", doctorId);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()){
                Console.WriteLine();
                Console.WriteLine($"Doctor ID      : {reader["DoctorID"]}");
                Console.WriteLine($"Name           : {reader["DoctorName"]}");
                Console.WriteLine($"Specialization : {reader["Specialization"]}");
                Console.WriteLine($"Qualification  : {reader["Qualification"]}");
                Console.WriteLine($"Experience     : {reader["Experience"]}");
                Console.WriteLine($"Phone Number   : {reader["PhoneNumber"]}");
                Console.WriteLine($"Email          : {reader["Email"]}");
                Console.WriteLine($"Room ID        : {reader["RoomID"]}");
            }else{
                throw new DoctorNotFoundException("Doctor Not Found.");
            }
            reader.Close();
        }
        catch(DoctorNotFoundException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    //---------------------------------------UPDATE DOCTOR--------------------------
    public void UpdateDoctor(){
    try{
        Console.Write("Enter Doctor ID : ");
        int doctorId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("What do you want to update?");
        Console.WriteLine("1. Experience");
        Console.WriteLine("2. Phone Number");
        Console.WriteLine("3. Room ID");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        using SqlConnection connection = db.GetConnection();
        connection.Open();
        SqlCommand cmd;
        switch (choice){
            case 1:
                Console.Write("Enter New Experience : ");
                int experience = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("sp_UpdateDoctorExperience", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@Experience", experience);
                break;

            case 2:
                Console.Write("Enter New Phone Number : ");
                string phone = Console.ReadLine()!;
                cmd = new SqlCommand("sp_UpdateDoctorPhone", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                break;

            case 3:
                Console.Write("Enter New Room ID : ");
                int roomId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("sp_UpdateDoctorRoom", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@RoomID", roomId);
                break;

            default:
                Console.WriteLine("Invalid Choice.");
                return;
        }
        int rows = cmd.ExecuteNonQuery();
        if (rows > 0){
            Console.WriteLine("\nDoctor Updated Successfully.");
        }else{
            throw new DoctorNotFoundException("Doctor Not Found.");
        }
    }catch (DoctorNotFoundException ex){
        Console.WriteLine(ex.Message);
    }catch (SqlException ex){
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex){
        Console.WriteLine(ex.Message);
    }
}

//-------------------------------------DELETE DOCTOR-----------------------
    public void DeleteDoctor(){
    try
    {
        Console.Write("Enter Doctor ID : ");
        int doctorId = Convert.ToInt32(Console.ReadLine());

        using SqlConnection connection = db.GetConnection();

        SqlCommand cmd = new SqlCommand("sp_DeleteDoctor", connection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@DoctorID", doctorId);

        connection.Open();

        int rows = cmd.ExecuteNonQuery();

        if (rows > 0)
            Console.WriteLine("\nDoctor Deleted Successfully.");
        else
            throw new DoctorNotFoundException("Doctor Not Found.");
    }
    catch (DoctorNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (SqlException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
}