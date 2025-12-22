// Write a program to check whether a person can vote, depending on whether his/her age is greater than or equal to 18.
using System;
class VotingAge{
  static void Main(string [] args){
    Console.WriteLine("Enter your age");
    int age=Convert.ToInt32(Console.ReadLine());
    //checking whether the person can vote or not
    if(age>=18){
      Console.WriteLine("The person's age is " + age + " and can vote.");
    }else{
      Console.WriteLine("The person's age is " + age + " and cannot vote.");
    }
  }
}