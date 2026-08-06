namespace HealthClinicApp.Entities;
public class Doctor{
    public int DoctorID { get; set; }
    public string DoctorName { get; set; }
    public string Specialization { get; set; }
    public string Qualification { get; set; }
    public int Experience { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int RoomID { get; set; }
    public Doctor(int doctorID,string doctorName,string specialization,string qualification,int experience, string phoneNumber,string email,int roomID){
        DoctorID = doctorID;
        DoctorName = doctorName;
        Specialization = specialization;
        Qualification = qualification;
        Experience = experience;
        PhoneNumber = phoneNumber;
        Email = email;
        RoomID = roomID;
    }
}