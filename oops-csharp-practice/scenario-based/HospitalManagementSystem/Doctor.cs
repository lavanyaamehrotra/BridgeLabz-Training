//separate class because doctor can be assigned to many patients 
public class Doctor{
  public int DoctorId{get;set;}
  public string Name{get;set;}
  public string Specialization{get;set;}
  public Doctor(int id,string name,string specilaization){
    DoctorId=id;
    Name=name;
    Specialization=specilaization;
  }
}
