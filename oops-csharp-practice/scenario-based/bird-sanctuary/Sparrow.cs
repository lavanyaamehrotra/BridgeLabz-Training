using System;
public class Sparrow : Bird, IFlyable{
  public Sparrow(string name,string species):base(name,species){}
  public void Fly(){
    Console.WriteLine($"{Name} is flying swiftly");
  }
}