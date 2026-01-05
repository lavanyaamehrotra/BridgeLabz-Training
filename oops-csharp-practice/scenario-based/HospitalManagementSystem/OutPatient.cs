public class OutPatient:Patient{
  //appointment date
  public DateTime AppointmentDate{get;set;}
  //Constructor
  public OutPatient(int id,string name,int age,Doctor doctor ,DateTime appointment) : base(id, name, age, doctor){
    AppointmentDate=appointment;
  }
  public override void DisplayInfo(){
    Console.WriteLine("\n -------out patient details------");
    base.DisplayInfo();
    Console.WriteLine($"Appointment Date:{AppointmentDate}");
  }
}