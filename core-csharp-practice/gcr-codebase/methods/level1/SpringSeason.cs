// Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
using System;
class SpringSeason{
  static void Main(string[] args){
    Console.WriteLine("Enter the month: ");
    int month=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the day: ");
    int day=Convert.ToInt32(Console.ReadLine());
    bool isSpring=IsSpringSeason(month,day);
    //printing whether its spring season or not
    if(isSpring){
      Console.WriteLine("It's a Spring Season");
    }else{
      Console.WriteLine("Not a Spring Season");
    }
  }
  static bool IsSpringSeason(int month, int day){
    //checking for spring season
    if((month==3 && day>=20 && day<=31) || (month==4 && day>=1 && day<=30) || (month==5 && day>=1 && day<=31) || (month==6 && day>=1 && day<=20)){
      return true;
    }else{
      return false;
    }
  }
}