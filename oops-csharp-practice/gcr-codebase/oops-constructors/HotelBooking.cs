using System;
class HotelBooking{
  public string GuestName;
  public string RoomType;
  public int Nights;
  // Default constructor
  public HotelBooking(){
    GuestName = "Unknown";
    RoomType = "Standard";
    Nights = 1;
  }
  // Parameterized constructor
  public HotelBooking(string guestName, string roomType, int nights){
    GuestName = guestName;
    RoomType = roomType;
    Nights = nights;
  }
  // Copy constructor
  public HotelBooking(HotelBooking other){
    GuestName = other.GuestName;
    RoomType = other.RoomType;
    Nights = other.Nights;
  }
  public void Display(){
    Console.WriteLine($"Guest Name: {GuestName}");
    Console.WriteLine($"Room Type: {RoomType}");
    Console.WriteLine($"Nights: {Nights}");
  }
}
class Program{
  static void Main(string[] args){
    // Default booking
    HotelBooking booking1 = new HotelBooking();
    booking1.Display();
    Console.WriteLine();
    // Parameterized booking
    HotelBooking booking2 = new HotelBooking("Alice", "Suite", 3);
    booking2.Display();
    Console.WriteLine();
    // Copy booking
    HotelBooking booking3 = new HotelBooking(booking2);
    booking3.Display();
    }
}
