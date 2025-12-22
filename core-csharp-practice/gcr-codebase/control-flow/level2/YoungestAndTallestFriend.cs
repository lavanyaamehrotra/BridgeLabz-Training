// Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
using System;
class YoungestAndTallestFriend{
  static void Main(string[] args){
    Console.Write("Enter Amar's age: ");
    int amarAge = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Akbar's age: ");
    int akbarAge = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Anthony's age: ");
    int anthonyAge = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Amar's height: ");
    int amarHeight = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Akbar's height: ");
    int akbarHeight = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Anthony's height: ");
    int anthonyHeight = Convert.ToInt32(Console.ReadLine());
    // Finding the youngest friend
    string youngestFriend;
    if (amarAge < akbarAge && amarAge < anthonyAge){
      youngestFriend = "Amar";
    }else if (akbarAge < amarAge && akbarAge < anthonyAge){
      youngestFriend = "Akbar";
    }else if (anthonyAge < amarAge && anthonyAge < akbarAge){
      youngestFriend = "Anthony";
    }else{
      youngestFriend = "There is a tie for the youngest friend";
    }
    // Finding the tallest friend
    string tallestFriend;
    if (amarHeight > akbarHeight && amarHeight > anthonyHeight){
      tallestFriend = "Amar";
    }else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight){
      tallestFriend = "Akbar";
    }else if (anthonyHeight > amarHeight && anthonyHeight > akbarHeight){
      tallestFriend = "Anthony";
    }else{
      tallestFriend = "There is a tie for the tallest friend";
    }
    Console.WriteLine("Youngest Friend: " + youngestFriend);
    Console.WriteLine("Tallest Friend: " + tallestFriend);
  }
}