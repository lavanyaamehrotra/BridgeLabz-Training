using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.Entities;
using HealthClinicApp.Interfaces;

namespace HealthClinicApp.Services;

public class BillingService : IBillingService
{
    DatabaseConnection db = new DatabaseConnection();

    //====================================================
    // ADD BILL
    //====================================================

    public void AddBill()
    {
        try
        {
            Console.Write("Appointment ID : ");
            int appointmentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Patient ID : ");
            int patientId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Amount : ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Payment Status : ");
            string paymentStatus = Console.ReadLine()!;

            Console.Write("Bill Date (yyyy-mm-dd) : ");
            DateTime billDate = Convert.ToDateTime(Console.ReadLine());

            Billing bill = new Billing(0,appointmentId,patientId,amount,paymentStatus,billDate);

            using SqlConnection connection = db.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Billing", connection);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable table = new DataTable();

            adapter.Fill(table);

            DataRow row = table.NewRow();

            row["AppointmentID"] = bill.AppointmentID;
            row["PatientID"] = bill.PatientID;
            row["Amount"] = bill.Amount;
            row["PaymentStatus"] = bill.PaymentStatus;
            row["BillDate"] = bill.BillDate;

            table.Rows.Add(row);

            adapter.Update(table);

            Console.WriteLine("\nBill Added Successfully.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // VIEW BILLS
    //====================================================

    public void ViewBills()
    {
        try
        {
            using SqlConnection connection = db.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Billing", connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Bill ID         : {row["BillID"]}");
                Console.WriteLine($"Appointment ID  : {row["AppointmentID"]}");
                Console.WriteLine($"Patient ID      : {row["PatientID"]}");
                Console.WriteLine($"Amount          : {row["Amount"]}");
                Console.WriteLine($"Payment Status  : {row["PaymentStatus"]}");
                Console.WriteLine($"Bill Date       : {row["BillDate"]}");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // SEARCH BILL
    //====================================================

    public void SearchBill()
    {
        try
        {
            Console.Write("Enter Bill ID : ");

            int billId = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Billing", connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            DataRow[] rows = table.Select($"BillID={billId}");

            if(rows.Length>0)
            {
                Console.WriteLine($"Bill ID         : {rows[0]["BillID"]}");
                Console.WriteLine($"Appointment ID  : {rows[0]["AppointmentID"]}");
                Console.WriteLine($"Patient ID      : {rows[0]["PatientID"]}");
                Console.WriteLine($"Amount          : {rows[0]["Amount"]}");
                Console.WriteLine($"Payment Status  : {rows[0]["PaymentStatus"]}");
                Console.WriteLine($"Bill Date       : {rows[0]["BillDate"]}");
            }
            else
            {
                Console.WriteLine("Bill Not Found.");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
        //====================================================
    // UPDATE BILL
    //====================================================

    public void UpdateBill()
    {
        try
        {
            Console.Write("Enter Bill ID : ");
            int billId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Amount");
            Console.WriteLine("2. Payment Status");
            Console.WriteLine("3. Bill Date");
            Console.Write("Enter Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Billing", connection);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable table = new DataTable();

            adapter.Fill(table);

            DataRow[] rows = table.Select($"BillID={billId}");

            if(rows.Length == 0)
            {
                Console.WriteLine("Bill Not Found.");
                return;
            }

            switch(choice)
            {
                case 1:

                    Console.Write("Enter New Amount : ");
                    rows[0]["Amount"] = Convert.ToDecimal(Console.ReadLine());
                    break;

                case 2:

                    Console.Write("Enter New Payment Status : ");
                    rows[0]["PaymentStatus"] = Console.ReadLine()!;
                    break;

                case 3:

                    Console.Write("Enter New Bill Date (yyyy-mm-dd) : ");
                    rows[0]["BillDate"] = Convert.ToDateTime(Console.ReadLine());
                    break;

                default:

                    Console.WriteLine("Invalid Choice.");
                    return;
            }

            adapter.Update(table);

            Console.WriteLine("\nBill Updated Successfully.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //====================================================
    // DELETE BILL
    //====================================================

    public void DeleteBill()
    {
        try
        {
            Console.Write("Enter Bill ID : ");

            int billId = Convert.ToInt32(Console.ReadLine());

            using SqlConnection connection = db.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Billing", connection);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable table = new DataTable();

            adapter.Fill(table);

            DataRow[] rows = table.Select($"BillID={billId}");

            if(rows.Length == 0)
            {
                Console.WriteLine("Bill Not Found.");
                return;
            }

            rows[0].Delete();

            adapter.Update(table);

            Console.WriteLine("\nBill Deleted Successfully.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}