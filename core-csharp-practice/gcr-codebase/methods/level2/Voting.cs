// Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18.
using System;
public class Voting{
  static void Main(){
    int[] studentAges = new int[10];
    Voting checker = new Voting();
    for (int i = 0; i < studentAges.Length; i++){
      Console.Write("Enter age of student " + (i + 1) + ": ");
      studentAges[i] = Convert.ToInt32(Console.ReadLine());
      // Check if student can vote
      bool canVote = checker.CanStudentVote(studentAges[i]);
      if (canVote){
        Console.WriteLine("Student " + (i + 1) + " can vote.");
      }else{
        Console.WriteLine("Student " + (i + 1) + " cannot vote.");
      }
    }
  }
  // Method to check if a student can vote
  public bool CanStudentVote(int age){
        if (age < 0){
            return false;
        }else if (age >= 18){
            return true;
        }else{
          return false;
        }
    }
}
