using System;
class Person{
  // Attributes
  public string Name;
  public int Age;
  public string Gender;

  // Parameterized constructor
  public Person(string name, int age, string gender){
    Name = name;
    Age = age;
    Gender = gender;
  }
  // Copy constructor
  public Person(Person other){
    Name = other.Name;
    Age = other.Age;
    Gender = other.Gender;
  }
  // Method to display person details
  public void Display(){
    Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
  }
}
class Program{
  static void Main(string[] args){
    // Original person
    Person person1 = new Person("Alice", 25, "Female");
    Console.WriteLine("Original Person:");
    person1.Display();
    // using copy constructor
    Person person2 = new Person(person1);
    Console.WriteLine("\nCopied Person:");
    person2.Display();
  }
}
