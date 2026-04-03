using System;
class FestivalLuckyDraw{
  public static void Main(string[] args){
    int visitors;
    Console.Write("Enter number of visitors: ");
    visitors = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= visitors; i++){
      Console.Write("\nVisitor " + i + ", enter your lucky number: ");
      int number;
      // Check for invalid input
      bool isValid = int.TryParse(Console.ReadLine(), out number);
      if (!isValid){
        Console.WriteLine("Invalid input! Try next visitor.");
        continue; 
      }
      // Check divisibility by 3 and 5
      if (number % 3 == 0 && number % 5 == 0) {
        Console.WriteLine("Congratulations! You won a gift!");
      }else{
        Console.WriteLine("Better luck next time!");
      }
    }
    Console.WriteLine("\nLucky Draw Completed. Happy Diwali! ");
  }
}