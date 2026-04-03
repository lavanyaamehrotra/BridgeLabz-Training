using System;
public class CallLog{
  public string PhoneNumber;
  public string Message;
  public DateTime Timestamp;
  public CallLog(string phoneNumber, string message, DateTime timestamp){
    PhoneNumber = phoneNumber;
    Message = message;
    Timestamp = timestamp;
  }
  public void Display(){
    Console.WriteLine("Phone Number:" + PhoneNumber);
    Console.WriteLine("Message:" + Message);
    Console.WriteLine("Timestamp:" + Timestamp);
    Console.WriteLine();
  }
}
