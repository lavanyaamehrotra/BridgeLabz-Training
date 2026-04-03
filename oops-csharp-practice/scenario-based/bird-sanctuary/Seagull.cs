using System;
public class Seagull : Bird, IFlyable, ISwimmable{
  public Seagull(string name, string species) : base(name, species) {}
  public void Fly(){
    Console.WriteLine($"{Name} is flying over the beach");
  }
  public void Swim(){
    Console.WriteLine($"{Name} is floating on the waves");
  }
}
