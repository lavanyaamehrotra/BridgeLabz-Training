using System;
public class Penguin : Bird, ISwimmable{
  public Penguin(string name, string species) : base(name, species) {}
  public void Swim(){
    Console.WriteLine($"{Name} is swimming in the pond");
  }
}
