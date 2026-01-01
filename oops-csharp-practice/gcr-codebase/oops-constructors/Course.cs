using System;
class Course{
    // Instance Variables
    public string courseName;
    public int duration;
    public double fee;
    // Class Variable 
    public static string instituteName = "GLA UNIVERSITY";
    // Constructor
  public Course(string name, int duration, double fee){
    this.courseName = name;
    this.duration = duration;
    this.fee = fee;
  }
  // Instance Method
  public void DisplayCousrs(){
    Console.WriteLine("Institute Name: " + instituteName);
    Console.WriteLine("Course Name: " + courseName);
    Console.WriteLine("Duration: " + duration + " months");
    Console.WriteLine("Fee: " + fee);
  }
  // Class Method
  public static void UpdateInstitute(string newName){
    instituteName = newName;
    Console.WriteLine("Institute name updated");
  }
}


// Test Program
class Program{
  static void Main(string[] args){
        Course c1 = new Course("Full Stack Development", 10, 50000);
        Course c2 = new Course("C Sharp", 6, 90000);
        c1.DisplayCousrs();
        Console.WriteLine();
        c2.DisplayCousrs();
        Console.WriteLine("\nUpdating Institute Name...\n");
        Course.UpdateInstitute("GLA UNIVERSITY MATHURA");
        Console.WriteLine();
        c1.DisplayCousrs();
        Console.WriteLine();
        c2.DisplayCousrs();
    }
}
