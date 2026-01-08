using System;
  public class Ac: Appliance{
  public Ac(cstring name) : base(name) { }
  public override void TurnOn(){
  Console.WriteLine($"{Name} AC is now ON. Temperature set to 24°C.");
  }
  public override void TurnOff(){
  Console.WriteLine($"{Name} AC is now OFF.");
  }
}

