using System;

// Superclass
class Animal{
  public string Name;
  public int Age;
  public Animal(string name, int age){
    Name = name;
    Age = age;
  }
  public virtual void MakeSound(){
    Console.WriteLine("Animal makes a sound.");
  }
  public void DisplayInfo(){
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Age: " + Age);
  }
}
// Subclass 1 — Dog
class Dog : Animal{
  public Dog(string name, int age): base(name, age) {}
  public override void MakeSound(){
    Console.WriteLine("Dog barks.");
  }
}
// Subclass 2 — Cat
class Cat : Animal{
  public Cat(string name, int age): base(name, age) {}
  public override void MakeSound(){
    Console.WriteLine("Cat meows.");
  }
}

// Subclass 3 — Bird
class Bird : Animal{
  public Bird(string name, int age): base(name, age) {}
  public override void MakeSound(){
    Console.WriteLine("Bird chirps.");
  }
}

// Main Class
class AnimalSystem{
  static void Main(string[] args){
    Animal dog = new Dog("Puppy", 3);
    Animal cat = new Cat("catty", 2);
    Animal bird = new Bird("birdy", 1);
    dog.DisplayInfo();
    dog.MakeSound();
    cat.DisplayInfo();
    cat.MakeSound();
    bird.DisplayInfo();
    bird.MakeSound();
  }
}
