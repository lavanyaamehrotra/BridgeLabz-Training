using System;
class Program{
  static void Main(string[] args){
    Doctor doc1=new Doctor(1,"Dr. Lavanya" ,"Cardiology");
    InPatient p1=new InPatient(2,"Lavi",21,doc1,roomno:1002,days:5);
    OutPatient p2=new OutPatient(3,"Riya",21,doc1,appointment:DateTime.Now.AddDays(1));
    p1.DisplayInfo();
    p2.DisplayInfo();
    Bill bill1=new Bill(p1,baseFee:2000,roomcharge:1500);
    bill1.PrintBill();
    Bill bill2=new Bill(p2,baseFee:2000,roomcharge:0);
    bill2.PrintBill();
  }
}