using System;
public class Program{
  public static void Main(){
    CallLogManager manager = new CallLogManager(5);
    manager.AddCallLog("9876543210", "Network issue reported", DateTime.Now.AddMinutes(-40));
    manager.AddCallLog("9123456780", "Recharge request completed", DateTime.Now.AddMinutes(-20));
    manager.AddCallLog("9988776655", "Customer asked about data pack", DateTime.Now);
    manager.SearchByKeyword("data");
    DateTime start = DateTime.Now.AddMinutes(-30);
    DateTime end = DateTime.Now;
    manager.FilterByTime(start, end);
    Console.ReadLine();
  }
}
