using System;
public class Bird{
  public string Name;
  public string Species;
  public Bird(string name,string species){
    Name=name;
    Species=species;
  }
  public virtual void Display(){
    Console.WriteLine($"Bird Name:{Name},Species:{Species}");
  }
}