//inheritance iNPATIENT IS-A PATIENT
public class InPatient : Patient{
  public int RoomNumber{get;set;}
  public int DaysAdmitted{get;set;}
  //constructor
  public InPatient(int id ,string name,int age,Doctor doctor,int roomno,int days):base(id,name,age,doctor){
  //calls the parent constructor
  RoomNumber=roomno;
  DaysAdmitted=days;
  }
  //Polymorphism
  public override void DisplayInfo(){
    Console.WriteLine("\n ------In-Patient Details------");
    base.DisplayInfo();
    Console.WriteLine($"Room Number:{RoomNumber}");
    Console.WriteLine($"Days Admitted: {DaysAdmitted}");
  }
}