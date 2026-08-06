using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Exceptions;

namespace HealthClinicApp.Services;

public class PatientService : IPatientService{
    DatabaseConnection db = new DatabaseConnection();
    //====================================================
    // ADD PATIENT
    //====================================================

    public void AddPatient(){
        try{
            Console.Write("Patient Name : ");
            string patientName = Console.ReadLine()!;
            Console.Write("Gender : ");
            string gender = Console.ReadLine()!;
            Console.Write("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Blood Group : ");
            string bloodGroup = Console.ReadLine()!;
            Console.Write("Phone Number : ");
            string phoneNumber = Console.ReadLine()!;
            Console.Write("City : ");
            string city = Console.ReadLine()!;
            Patient patient = new Patient(0,patientName,gender,age,bloodGroup,phoneNumber,city);

            using SqlConnection connection = db.GetConnection();
            string query = @"INSERT INTO Patient(PatientName,Gender,Age,BloodGroup,PhoneNumber,City)
            VALUES( @PatientName,@Gender,@Age,@BloodGroup,@PhoneNumber,@City)";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PatientName", patient.PatientName);
            cmd.Parameters.AddWithValue("@Gender", patient.Gender);
            cmd.Parameters.AddWithValue("@Age", patient.Age);
            cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
            cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
            cmd.Parameters.AddWithValue("@City", patient.City);

            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0){
                Console.WriteLine("\nPatient Added Successfully.");
            }else{
                Console.WriteLine("\nPatient Not Added.");
            }
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
    // VIEW PATIENTS
    //====================================================

    public void ViewPatients(){
        try{
            using SqlConnection connection = db.GetConnection();
            string query = "SELECT * FROM Patient";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine();
            while(reader.Read()){
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Patient ID     : {reader["PatientID"]}");
                Console.WriteLine($"Patient Name   : {reader["PatientName"]}");
                Console.WriteLine($"Gender         : {reader["Gender"]}");
                Console.WriteLine($"Age            : {reader["Age"]}");
                Console.WriteLine($"Blood Group    : {reader["BloodGroup"]}");
                Console.WriteLine($"Phone Number   : {reader["PhoneNumber"]}");
                Console.WriteLine($"City           : {reader["City"]}");
            }

            reader.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // SEARCH PATIENT
    //====================================================

    public void SearchPatient(){
        try{
            Console.Write("Enter Patient ID : ");
            int patientId = Convert.ToInt32(Console.ReadLine());
            using SqlConnection connection = db.GetConnection();
            string query = "SELECT * FROM Patient WHERE PatientID=@PatientID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PatientID", patientId);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()){
                Console.WriteLine();
                Console.WriteLine($"Patient ID     : {reader["PatientID"]}");
                Console.WriteLine($"Patient Name   : {reader["PatientName"]}");
                Console.WriteLine($"Gender         : {reader["Gender"]}");
                Console.WriteLine($"Age            : {reader["Age"]}");
                Console.WriteLine($"Blood Group    : {reader["BloodGroup"]}");
                Console.WriteLine($"Phone Number   : {reader["PhoneNumber"]}");
                Console.WriteLine($"City           : {reader["City"]}");
            }
            else{
                throw new PatientNotFoundException("Patient Not Found.");
            }
            reader.Close();
        }
        catch(PatientNotFoundException ex){
            Console.WriteLine(ex.Message);
        }
        catch(SqlException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    //====================================================
    // UPDATE PATIENT
    //====================================================

    public void UpdatePatient(){
        try{
            Console.Write("Enter Patient ID : ");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("1. Age");
            Console.WriteLine("2. Phone Number");
            Console.WriteLine("3. City");
            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            using SqlConnection connection = db.GetConnection();
            connection.Open();
            SqlCommand cmd;
            switch(choice){
                case 1:
                    Console.Write("Enter New Age : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    cmd = new SqlCommand(@"UPDATE Patient SET Age=@Age WHERE PatientID=@PatientID",connection);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    break;

                case 2:
                    Console.Write("Enter New Phone Number : ");
                    string phone = Console.ReadLine()!;
                    cmd = new SqlCommand(@"UPDATE Patient SET PhoneNumber=@PhoneNumber WHERE PatientID=@PatientID",connection);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    break;

                case 3:
                    Console.Write("Enter New City : ");
                    string city = Console.ReadLine()!;
                    cmd = new SqlCommand(@"UPDATE PatientSET City=@City WHERE PatientID=@PatientID",connection);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    return;
            }
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
                Console.WriteLine("\nPatient Updated Successfully.");
            else
                throw new PatientNotFoundException("Patient Not Found.");
        }
        catch(PatientNotFoundException ex){
            Console.WriteLine(ex.Message);
        }
        catch(SqlException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // DELETE PATIENT
    //====================================================

    public void DeletePatient()
    {
        try
        {
            Console.Write("Enter Patient ID : ");
            int patientId = Convert.ToInt32(Console.ReadLine());
            using SqlConnection connection = db.GetConnection();
            string query = @"DELETE FROM Patient WHERE PatientID=@PatientID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PatientID", patientId);
            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
                Console.WriteLine("\nPatient Deleted Successfully.");
            else
                throw new PatientNotFoundException("Patient Not Found.");
        }
        catch(PatientNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
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