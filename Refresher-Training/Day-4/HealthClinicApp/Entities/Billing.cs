namespace HealthClinicApp.Entities;
public class Billing{
    public int BillID { get; set; }
    public int AppointmentID { get; set; }
    public int PatientID { get; set; }
    public decimal Amount { get; set; }
    public string PaymentStatus { get; set; }
    public DateTime BillDate { get; set; }
    public Billing(int billID,int appointmentID,int patientID,decimal amount,string paymentStatus,DateTime billDate){
        BillID = billID;
        AppointmentID = appointmentID;
        PatientID = patientID;
        Amount = amount;
        PaymentStatus = paymentStatus;
        BillDate = billDate;
    }
}