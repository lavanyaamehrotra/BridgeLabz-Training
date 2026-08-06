namespace HealthClinicApp.Entities;
public class Appointment{
    public int AppointmentID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public TimeSpan AppointmentTime { get; set; }
    public string VisitType { get; set; }
    public string AppointmentStatus { get; set; }
    public int DoctorID { get; set; }
    public int PatientID { get; set; }
    public Appointment(int appointmentID,DateTime appointmentDate,TimeSpan appointmentTime,string visitType,string appointmentStatus,int doctorID,int patientID){
        AppointmentID = appointmentID;
        AppointmentDate = appointmentDate;
        AppointmentTime = appointmentTime;
        VisitType = visitType;
        AppointmentStatus = appointmentStatus;
        DoctorID = doctorID;
        PatientID = patientID;
    }
}