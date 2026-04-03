using System;

class DateComparison{
  static void Main(){
    //input
    DateTime date1 = Convert.ToDateTime(Console.ReadLine());
    DateTime date2 = Convert.ToDateTime(Console.ReadLine());
    int ans = DateTime.Compare(date1, date2);
    //checking which date is previous 
    if (ans < 0){
      Console.WriteLine("First date is previous of the second date");
    }else if (ans > 0){
      Console.WriteLine("First date is post second date");
    }else{
      Console.WriteLine("Both dates are same");
    }
  }
}