using System;
using Microsoft.Data.SqlClient;

public class AdminUtilityService : IAdminUtilityService{
    /* ===============================
       UC-6.1: Manage Specialties
       Actor: Administrator
    ================================ */
    public void ManageSpecialties(){
        Console.WriteLine("1. Add Specialty");
        Console.WriteLine("2. View Specialties");
        Console.WriteLine("3. Delete Specialty");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());
        using SqlConnection con = DBConnection.GetConnection();
        con.Open();
        if (choice == 1){
            Console.Write("Specialty Name: ");
            string name = Console.ReadLine();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Specialization (specialist_name) VALUES (@n)", con);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.ExecuteNonQuery();
        }
        else if (choice == 2){
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Specialization", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                Console.WriteLine($"{dr["specialist_id"]} - {dr["specialist_name"]}");
        }
        else if (choice == 3){
            Console.Write("Enter Specialist ID: ");
            int id = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand(
                "sp_DeleteSpecialization", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@specialist_id", id);
            cmd.ExecuteNonQuery();
        }
    }
    /* ===============================
       UC-6.3: View Audit Logs
       Actor: Administrator
    ================================ */
    public void ViewAuditLogs(){
        using SqlConnection con = DBConnection.GetConnection();
        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Audit_Log ORDER BY action_date DESC", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read()){
            Console.WriteLine(
                $"{dr["table_name"]} | {dr["action"]} | {dr["action_date"]}");
        }
    }
}
