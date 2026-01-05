using System;
public abstract class Patient{
  public int PatientId{get;set;}
  public string Name {get;set;}
  public int Age{get;set;}
  //patient HAS-A doctor
  public Doctor AssignedDoctor{get;set;}
  //Constructor
  public Patient(int id,string name,int age,Doctor doctor){
    PatientId=id;
    Name=name;
    Age=age;
    AssignedDoctor=doctor;
  }
  //polymorphism
  public virtual void DisplayInfo(){
    Console.WriteLine($"Patient Id:{PatientId}");
    Console.WriteLine($"Name:{Name}");
    Console.WriteLine($"Age:{Age}");
    Console.WriteLine($"Assigned Doctor:{AssignedDoctor.Name}({AssignedDoctor.Specilaization})");
  }

}