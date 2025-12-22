// Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
using System;
class SpringSeason{
  static void Main(String[] args){
    Console.WriteLine("Enter month");
    int month=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter day");
    int day=Convert.ToInt32(Console.ReadLine());
    //check whether it is apring season or not
    if((month==3 && day>=20 && day<=31) || (month==4 && day>=1 && day<=30) || (month==5 && day>=1 && day<=31) || (month==6 && day>=1 && day<=20)){
      Console.WriteLine("Its a Spring Season");
    }else{
      Console.WriteLine("Not a Spring Season");
    }
  }
}