using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Exceptions;

namespace HealthClinicApp.Services;

public class RoomService : IRoomService
{
    DatabaseConnection db = new DatabaseConnection();

    //====================================================
    // ADD ROOM
    //====================================================

    public void AddRoom()
    {
        try
        {
            Console.Write("Room Number : ");
            string roomNumber = Console.ReadLine()!;

            Console.Write("Floor Number : ");
            int floorNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Room Type : ");
            string roomType = Console.ReadLine()!;

            Room room = new Room(0, roomNumber, floorNumber, roomType);

            using SqlConnection connection = db.GetConnection();

            string query = @"INSERT INTO Room(RoomNumber,FloorNumber,RoomType)
                             VALUES(@RoomNumber,@FloorNumber,@RoomType)";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@FloorNumber", room.FloorNumber);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);

            connection.Open();

            int rows = cmd.ExecuteNonQuery();

            if(rows > 0)
                Console.WriteLine("\nRoom Added Successfully.");
            else
                Console.WriteLine("\nRoom Not Added.");
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
    // VIEW ROOMS
    //====================================================

    public void ViewRooms()
    {
        try
        {
            using SqlConnection connection = db.GetConnection();

            string query = "SELECT * FROM Room";

            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Room ID        : {reader["RoomID"]}");
                Console.WriteLine($"Room Number    : {reader["RoomNumber"]}");
                Console.WriteLine($"Floor Number   : {reader["FloorNumber"]}");
                Console.WriteLine($"Room Type      : {reader["RoomType"]}");
            }

            reader.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // SEARCH ROOM
    //====================================================

    public void SearchRoom()
    {
        try
        {
            Console.Write("Enter Room ID : ");

            int roomId = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            string query = "SELECT * FROM Room WHERE RoomID=@RoomID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@RoomID", roomId);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                Console.WriteLine($"Room ID        : {reader["RoomID"]}");
                Console.WriteLine($"Room Number    : {reader["RoomNumber"]}");
                Console.WriteLine($"Floor Number   : {reader["FloorNumber"]}");
                Console.WriteLine($"Room Type      : {reader["RoomType"]}");
            }
            else
            {
                throw new RoomNotFoundException("Room Not Found.");
            }

            reader.Close();
        }
        catch(RoomNotFoundException ex)
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

    //====================================================
    // UPDATE ROOM
    //====================================================

    public void UpdateRoom()
    {
        try
        {
            Console.Write("Enter Room ID : ");
            int roomId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Room Number");
            Console.WriteLine("2. Floor Number");
            Console.WriteLine("3. Room Type");
            Console.Write("Enter Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            connection.Open();

            SqlCommand cmd;

            switch(choice)
            {
                case 1:

                    Console.Write("Enter New Room Number : ");
                    string roomNumber = Console.ReadLine()!;

                    cmd = new SqlCommand(@"UPDATE Room SET RoomNumber=@RoomNumber WHERE RoomID=@RoomID", connection);

                    cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    break;

                case 2:

                    Console.Write("Enter New Floor Number : ");
                    int floor = Convert.ToInt32(Console.ReadLine());

                    cmd = new SqlCommand(@"UPDATE Room SET FloorNumber=@FloorNumber WHERE RoomID=@RoomID", connection);

                    cmd.Parameters.AddWithValue("@FloorNumber", floor);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    break;

                case 3:

                    Console.Write("Enter New Room Type : ");
                    string roomType = Console.ReadLine()!;

                    cmd = new SqlCommand(@"UPDATE Room SET RoomType=@RoomType WHERE RoomID=@RoomID", connection);

                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    break;

                default:

                    Console.WriteLine("Invalid Choice.");
                    return;
            }

            int rows = cmd.ExecuteNonQuery();

            if(rows > 0)
                Console.WriteLine("\nRoom Updated Successfully.");
            else
                throw new RoomNotFoundException("Room Not Found.");
        }
        catch(RoomNotFoundException ex)
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

    //====================================================
    // DELETE ROOM
    //====================================================

    public void DeleteRoom()
    {
        try
        {
            Console.Write("Enter Room ID : ");

            int roomId = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            string query = "DELETE FROM Room WHERE RoomID=@RoomID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@RoomID", roomId);

            connection.Open();

            int rows = cmd.ExecuteNonQuery();

            if(rows > 0)
                Console.WriteLine("\nRoom Deleted Successfully.");
            else
                throw new RoomNotFoundException("Room Not Found.");
        }
        catch(RoomNotFoundException ex)
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