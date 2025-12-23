// Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18. 
using System;
class Voting{
  static void Main(string[] args){
    int[] ages=new int[10];
    for(int i=0;i<ages.length;i++){
      Console.WriteLine("Enter age of student " + (i+1) + ":");
      ages[i]=Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<ages.Length;i++){
      if(ages[i]<0){
        Console.WriteLine("Invalid age: " + ages[i]);
      }else if(ages[i]>=18){
        Console.WriteLine("The student with the age " + ages[i] + " can vote.");
      }else{
        Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
      }
    }
  }
}