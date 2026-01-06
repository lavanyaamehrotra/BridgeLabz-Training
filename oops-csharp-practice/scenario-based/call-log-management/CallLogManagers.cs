using System;
public class CallLogManager{
  private CallLog[] logs;
  private int count = 0;
  public CallLogManager(int size){
    logs = new CallLog[size];
  }
  public void AddCallLog(string phoneNumber, string message, DateTime time){
    if (count >= logs.Length){
      Console.WriteLine("Cannot add more logs");
      return;
    }
    logs[count] = new CallLog(phoneNumber, message, time);
    count++;
    Console.WriteLine("Call Log added successfully\n");
    }
    public void SearchByKeyword(string keyword){
      Console.WriteLine("Searching logs containing: " + keyword);
      bool found = false;
      for (int i = 0; i < count; i++){
        if (logs[i].Message.Contains(keyword)){
          logs[i].Display();
          found = true;
        }
      }if (!found){
        Console.WriteLine("No logs found\n");
      }
    }
  public void FilterByTime(DateTime start, DateTime end){
    Console.WriteLine("Filtering logs between:");
    Console.WriteLine(start + " AND " + end);
    bool found = false;
    for (int i = 0; i < count; i++){
      if (logs[i].Timestamp >= start && logs[i].Timestamp <= end){
        logs[i].Display();
        found = true;
      }
    }
    if (!found){
      Console.WriteLine("No logs found in this time range\n");
    }
  }
}
