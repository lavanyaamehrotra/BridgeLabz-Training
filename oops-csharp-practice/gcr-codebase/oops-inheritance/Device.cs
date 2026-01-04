using System;
// Superclass — Device
class Device{
    public string DeviceId;
    public string Status;
    public Device(string deviceId, string status){
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus(){
        Console.WriteLine($"Device ID: {DeviceId}");
        Console.WriteLine($"Status: {Status}");
    }
}

// Subclass — Thermostat
class Thermostat : Device{
    public double TemperatureSetting;
    public Thermostat(string deviceId, string status, double temperature): base(deviceId, status){
        TemperatureSetting = temperature;
    }

    public override void DisplayStatus(){
        Console.WriteLine("\nSmart Thermostat Details:");
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting} °C");
    }
}
// Main Class
class SmartHomeSystem{
    static void Main(string[] args){
      Thermostat t1 = new Thermostat("TH-1023", "Online", 24.5);
      t1.DisplayStatus();
    }
}
