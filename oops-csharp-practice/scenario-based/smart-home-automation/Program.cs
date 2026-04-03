using System;
  internal class Program{
    static void Main(string[] args){
    Light livingRoomLight = new Light("Living Room");
    Fan bedroomFan = new Fan("Bedroom");
    Ac guestRoomAC = new Ac("Guest Room");
    Console.WriteLine("Smart Home Automation System\n");
    Console.WriteLine("Turning ON:\n");
    livingRoomLight.TurnOn();
    bedroomFan.TurnOn();
    guestRoomAC.TurnOn();
    Console.WriteLine("\nTurning OFF:\n");
    livingRoomLight.TurnOff();
    bedroomFan.TurnOff();
    guestRoomAC.TurnOff();
    Console.WriteLine("\nAutomation Complete");
  }
}

