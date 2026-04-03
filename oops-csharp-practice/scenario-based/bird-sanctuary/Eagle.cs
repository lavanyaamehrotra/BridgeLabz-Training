using System;
public class Eagle:Bird, IFlyable{
  public Eagle(string name,string species):base(name,species){}
  public void Fly(){
    Console.WriteLine($"{Name} is flying swiftly");
  }
}