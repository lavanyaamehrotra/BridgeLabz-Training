using System;
public class Duck : Bird, ISwimmable{
  public Duck(string name, string species) : base(name, species) {}
  public void Swim(){
    Console.WriteLine($"{Name} is swimming in the pond");
  }
}

