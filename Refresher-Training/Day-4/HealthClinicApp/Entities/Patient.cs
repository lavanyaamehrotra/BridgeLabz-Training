namespace HealthClinicApp.Entities;
public class Patient{
    public int PatientID { get; set; }
    public string PatientName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string BloodGroup { get; set; }
    public string PhoneNumber { get; set; }
    public string City { get; set; }
    public Patient(int patientID,string patientName,string gender,int age,string bloodGroup,string phoneNumber,string city){
        PatientID = patientID;
        PatientName = patientName;
        Gender = gender;
        Age = age;
        BloodGroup = bloodGroup;
        PhoneNumber = phoneNumber;
        City = city;
    }
}