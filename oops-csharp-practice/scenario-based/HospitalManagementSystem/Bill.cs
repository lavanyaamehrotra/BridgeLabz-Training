public class Bill : IPayable{
  public Patient Patient{get;set;}
  public decimal BaseFee{get;set;}
  public decimal RoomChargePerDay{get;set;}
  public Bill(Patient patient,decimal basefee,decimal roomcharge){
    Patient=patient;
    BaseFee=basefee;
    RoomChargePerDay=roomcharge;
  }
  public decimal CalculateBill(){
    if(Patient is InPatient inPatient){
      return BaseFee+(inPatient.DaysAdmitted * RoomChargePerDay);
    }
    return BaseFee;
  }
  public void PrintBill(){
    Console.WriteLine("\n---------Bill------------");
    Patient.DisplayInfo();
    Console.WriteLine($"Total Amount:{CalculateBill()}");
  }
}