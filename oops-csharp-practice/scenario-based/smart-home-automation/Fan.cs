using System;
  public class Fan : Appliance{
  public Fan(string name) : base(name) { }
  public override void TurnOn(){
  Console.WriteLine($"{Name} Fan is now ON. Speed set to Medium.");
  }
  public override void TurnOff(){
  Console.WriteLine($"{Name} Fan is now OFF.");
  }
}
