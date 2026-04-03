using System;
// Superclass
class PersonSchool{
  public string Name;
  public int Age;
  public PersonSchool(string name, int age){
    Name = name;
    Age = age;
  }
  public void DisplayDetails(){
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Age: " + Age);
  }
}
// Subclass 1 — Teacher
class Teacher : PersonSchool{
  public string Subject;
  public Teacher(string name, int age,string subject): base(name, age){
    Subject = subject;
  }
  public void DisplayRole(){
    Console.WriteLine("\nRole: Teacher");
    DisplayDetails();
    Console.WriteLine("Subject: " + Subject);
  }
}
// Subclass 2 — Student
class Student : PersonSchool{
  public string Grade;
  public Student(string name, int age, string grade): base(name, age){
    Grade = grade;
  }
  public void DisplayRole(){
    Console.WriteLine("\nRole: Student");
    DisplayDetails();
    Console.WriteLine("Grade: " + Grade);
  }
}
// Subclass 3 — Staff
class Staff : PersonSchool{
  public string Department;
  public Staff(string name, int age, string department): base(name, age){
    Department = department;
  }
  public void DisplayRole(){
    Console.WriteLine("\nRole: Staff");
    DisplayDetails();
    Console.WriteLine("Department: " + Department);
  }
}

// Main Class
class SchoolSystem{
  static void Main(string[] args){
    Teacher t1 = new Teacher("Lavanya Mehrotra", 26, "Maths");
    Student s1 = new Student("Khushi Tiwari", 33, "10th Grade");
    Staff st1 = new Staff("Roshni Srivastava", 56, "Administration");
    t1.DisplayRole();
    s1.DisplayRole();
    st1.DisplayRole();
  }
}
