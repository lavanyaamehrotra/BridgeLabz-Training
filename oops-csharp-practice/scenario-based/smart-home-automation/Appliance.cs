using System;
// Base class for all appliances
  public abstract class Appliance : IControllable{
    public string Name { get; set; }
    public Appliance(string name){
      Name = name;
    }
    public abstract void TurnOn(); 
    public abstract void TurnOff();
  }

