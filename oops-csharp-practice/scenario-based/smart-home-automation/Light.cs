using System;
public class Light : Appliance{
  public Light(string name) : base(name) { }
  public override void TurnOn(){
    Console.WriteLine($"{Name} Light is now ON. Brightness set to 70%.");
  
  }
  public override void TurnOff(){
  Console.WriteLine($"{Name} Light is now OFF.");
  }
}
