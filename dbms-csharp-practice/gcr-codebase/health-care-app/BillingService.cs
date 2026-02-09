using System;
using Microsoft.Data.SqlClient;

public class BillingService : IBillingService
{
    /* ===============================
       UC-5.1: Generate Bill
       Actor: Receptionist
    ================================ */
    public void GenerateBill()
    {
        Console.Write("Enter Visit ID: ");
        int visitId = int.Parse(Console.ReadLine());

        using SqlConnection con = DBConnection.GetConnection();
        con.Open();

        // Get doctor's consultation fee
        string feeQuery = @"
            SELECT d.consultation_fee
            FROM Visit v
            JOIN Appointment a ON v.appointment_id = a.appointment_id
            JOIN Doctor d ON a.doctor_id = d.doctor_id
            WHERE v.visit_id = @vid";

        SqlCommand feeCmd = new SqlCommand(feeQuery, con);
        feeCmd.Parameters.AddWithValue("@vid", visitId);

        decimal consultationFee = (decimal)feeCmd.ExecuteScalar();

        // Insert bill
        SqlCommand insertCmd = new SqlCommand(
            "INSERT INTO Billing (visit_id, total_amount, payment_status) VALUES (@v,@t,'UNPAID')",
            con);

        insertCmd.Parameters.AddWithValue("@v", visitId);
        insertCmd.Parameters.AddWithValue("@t", consultationFee);
        insertCmd.ExecuteNonQuery();

        Console.WriteLine($"Bill Generated. Amount: ₹{consultationFee}");
    }

    /* ===============================
       UC-5.2: Record Payment
       Actor: Receptionist
    ================================ */
    public void RecordPayment()
    {
        Console.Write("Enter Bill ID: ");
        int billId = int.Parse(Console.ReadLine());

        Console.Write("Payment Mode (Cash/Card/UPI): ");
        string mode = Console.ReadLine();

        using SqlConnection con = DBConnection.GetConnection();
        con.Open();
        SqlTransaction tx = con.BeginTransaction();

        try
        {
            SqlCommand updateBill = new SqlCommand(
                "UPDATE Billing SET payment_status='PAID' WHERE bill_id=@b",
                con, tx);
            updateBill.Parameters.AddWithValue("@b", billId);
            updateBill.ExecuteNonQuery();

            SqlCommand insertPayment = new SqlCommand(
                @"INSERT INTO Payment_Transactions (bill_id, payment_mode, amount)
                  SELECT bill_id, @m, total_amount FROM Billing WHERE bill_id=@b",
                con, tx);

            insertPayment.Parameters.AddWithValue("@b", billId);
            insertPayment.Parameters.AddWithValue("@m", mode);
            insertPayment.ExecuteNonQuery();

            tx.Commit();
            Console.WriteLine("Payment recorded successfully.");
        }
        catch
        {
            tx.Rollback();
            Console.WriteLine(" Payment failed.");
        }
    }

    /* ===============================
       UC-5.3: View Outstanding Bills
       Actor: Receptionist / Administrator
    ================================ */
    public void ViewOutstandingBills()
    {
        using SqlConnection con = DBConnection.GetConnection();

        SqlCommand cmd = new SqlCommand(
            @"SELECT p.name,
                     COUNT(b.bill_id) AS bill_count,
                     SUM(b.total_amount) AS total_due
              FROM Billing b
              JOIN Visit v ON b.visit_id = v.visit_id
              JOIN Appointment a ON v.appointment_id = a.appointment_id
              JOIN Patient p ON a.patient_id = p.patient_id
              WHERE b.payment_status='UNPAID'
              GROUP BY p.name", con);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine(
                $"{dr["name"]} | Bills: {dr["bill_count"]} | Due: ₹{dr["total_due"]}");
        }
    }

    /* ===============================
       UC-5.4: Revenue Report
       Actor: Administrator
    ================================ */
    public void GenerateRevenueReport()
    {
        Console.Write("From Date (yyyy-mm-dd): ");
        DateTime from = DateTime.Parse(Console.ReadLine());

        Console.Write("To Date (yyyy-mm-dd): ");
        DateTime to = DateTime.Parse(Console.ReadLine());

        using SqlConnection con = DBConnection.GetConnection();
        SqlCommand cmd = new SqlCommand("sp_RevenueReport", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@fromDate", from);
        cmd.Parameters.AddWithValue("@toDate", to);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine(
                $"{dr["doctor_name"]} ({dr["specialist_name"]}) → ₹{dr["total_revenue"]}");
        }
    }
}
