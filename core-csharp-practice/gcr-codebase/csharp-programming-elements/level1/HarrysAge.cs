//1. Write a program to find the age of Harry if the birth year is 2000. Assume the Current Year is 2024
using System;
class HarrysAge{
  static void Main(string[] args){
    int birthyear=2000;
    int currentyear=2024;
    //formula to calculate current age 
    int age=currentyear-birthyear;
    Console.WriteLine("Harry's age in 2024 is " + age);
  }
}