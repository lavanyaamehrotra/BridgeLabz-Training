using System;
// Base Class
class Employee{
  public string Name;
  public int Id;
  public double Salary;
  public Employee(string name, int id, double salary){
    Name = name;
    Id = id;
    Salary = salary;
  }
  public virtual void DisplayDetails(){
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"ID: {Id}");
    Console.WriteLine($"Salary: {Salary}");
  }
}

// Subclass — Manager
class Manager : Employee{
  public int TeamSize;
  public Manager(string name, int id, double salary, int teamSize): base(name, id, salary){
    TeamSize = teamSize;
  }
  public override void DisplayDetails(){
    Console.WriteLine("\nRole: Manager");
    base.DisplayDetails();
    Console.WriteLine($"Team Size: {TeamSize}");
  }
}

// Subclass — Developer
class Developer : Employee{
  public string ProgrammingLanguage;
  public Developer(string name, int id, double salary, string language): base(name, id, salary){
    ProgrammingLanguage = language;
  }
  public override void DisplayDetails(){
    Console.WriteLine("\nRole: Developer");
    base.DisplayDetails();
    Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
  }
}

// Subclass — Intern
class Intern : Employee{
  public string InternshipDuration;
  public Intern(string name, int id, double salary, string duration): base(name, id, salary){
    InternshipDuration = duration;
  }
  public override void DisplayDetails(){
    Console.WriteLine("\nRole: Intern");
    base.DisplayDetails();
    Console.WriteLine($"Duration: {InternshipDuration}");
  }
}

// Main Class
class EmployeeSystem{
  static void Main(string[] args){
    Employee m = new Manager("Lavanya Mehrotra", 101, 96000, 4);
    Employee d = new Developer("Khushi Tiwari", 102, 12000, "C#");
    Employee i = new Intern("Roshni Srivastava", 103, 89000, "6 Months");
    m.DisplayDetails();
    d.DisplayDetails();
    i.DisplayDetails();
  }
}
