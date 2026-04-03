using System;
class Student{
  // Public Member
  public int rollNumber;
  // Protected Member 
  protected string name;
  // Private Member 
  private double CGPA;
  // Constructor
  public Student(int rollNumber, string name, double cgpa){
    this.rollNumber = rollNumber;
    this.name = name;
    this.CGPA = cgpa;
  }
  // Public Method 
  public void SetCGPA(double cgpa){
    if (cgpa >= 0 && cgpa <= 10){
      CGPA = cgpa;
    }else{
      Console.WriteLine("Invalid");
    }
  }
  // Public Method
  public double GetCGPA(){
    return CGPA;
  }
  // Display Method
  public void DisplayStudentDetails(){
    Console.WriteLine("Roll Number: " + rollNumber);
    Console.WriteLine("Name: " + name);
    Console.WriteLine("CGPA: " + CGPA);
  }
}

// Derived Class
class PostgraduateStudent : Student{
  public string specialization;
  public PostgraduateStudent(int roll, string name, double cgpa, string specialization): base(roll, name, cgpa){
    this.specialization = specialization;
  }
  public void DisplayPostgraduateDetails(){
    Console.WriteLine("\n(Postgraduate Student Details)");
    Console.WriteLine("Roll Number: " + rollNumber);
    // Accessing PROTECTED member (allowed)
    Console.WriteLine("Name: " + name);
    // CGPA cannot be accessed directly because it's PRIVATE
    Console.WriteLine("Specialization: " + specialization);
  }
}
class Program{
  static void Main(string[] args){
    Student s1 = new Student(26, "Lavanya Mehrotra", 8.39);
    s1.DisplayStudentDetails();
    Console.WriteLine("\nUpdating CGPA...");
    s1.SetCGPA(8.46);
    Console.WriteLine("Updated CGPA: " + s1.GetCGPA());
    PostgraduateStudent pg = new PostgraduateStudent(32, "Khushi Tiwari", 8.4, "Computer Science");
    pg.DisplayPostgraduateDetails();
  }
}
