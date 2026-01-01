using System;
class Student{
  // Static variable shared among all students
  public static string UniversityName = "GLA UNIVERSITY";
  // Static field to track total students
  private static int TotalStudents = 0;
  // Static method to display total students
  public static void displayTotalStudent(){
    Console.WriteLine($"TOTAL STUDENTS ENROLLED: {TotalStudents}\n");
  }
  // Readonly variable
  public readonly int RollNumber;
  // Instance variables
  public string Name;
  public string Grade;
  // Constructor 
  public Student(int rollNumber, string name, string grade){
    this.RollNumber = rollNumber;
    this.Name = name;
    this.Grade = grade;
    TotalStudents++;
  }
  public void DisplayStudent(){
    Console.WriteLine("Student Details:");
    Console.WriteLine($"University: {UniversityName}");
    Console.WriteLine($"Roll No: {RollNumber}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Grade: {Grade}\n");
  }
  public void UpdateGrade(string newGrade){
    this.Grade = newGrade;
    Console.WriteLine($"Grade updated for {Name} to {Grade}\n");
  }
}
class UniversitySystem{
  static void Main(){
    object s1 = new Student(101, "Aditi Sharma", "A");
    object s2 = new Student(102, "Rohit Verma", "B");
    // Using 'is' operator
    if (s1 is Student){
      Student student1 = (Student)s1;
      student1.DisplayStudent();
      student1.UpdateGrade("A+");
    }
    if (s2 is Student){
      Student student2 = (Student)s2;
      student2.DisplayStudent();
    }
    // Display total student
    Student.displayTotalStudent();
    Console.ReadLine();
  }
}
