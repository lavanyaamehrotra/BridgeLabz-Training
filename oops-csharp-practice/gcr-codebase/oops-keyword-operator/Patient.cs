using System;
class Patient{
  public static string HospitalName = "Nazerth Hospital";
  //count total admitted patients
  private static int TotalPatients = 0;
  // Static method to return total patients
  public static void GetTotalPatients(){
    Console.WriteLine($"\nTotal Patients Admitted{TotalPatients}\n");
  }
  // Readonly Patient ID
  public readonly int PatientID;
  // Instance variables
  public string Name;
  public int Age;
  public string Ailment;
  // Constructor
  public Patient(int patientID, string name, int age, string ailment){
    this.PatientID = patientID;
    this.Name = name;
    this.Age = age;
    this.Ailment = ailment;
    TotalPatients++;
  }
  public void DisplayDetails(){
    Console.WriteLine("Patient Details:");
    Console.WriteLine($"Hospital: {HospitalName}");
    Console.WriteLine($"Patient ID: {PatientID}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Age: {Age}");
    Console.WriteLine($"Ailmen: {Ailment}\n");
  }
}
class HospitalSystem{
  static void Main(){
    object p1 = new Patient(123, "sanvi", 29, "Fever");
    object p2 = new Patient(321, "priya", 41, "Fracture");
    if (p1 is Patient){
      ((Patient)p1).DisplayDetails();
    }
    if (p2 is Patient){
      ((Patient)p2).DisplayDetails();
    }
    // Display total patient
    Patient.GetTotalPatients();
    Console.ReadLine();
  }
}
