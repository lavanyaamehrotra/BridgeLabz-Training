// Create a program to find the maximum number of handshakes among N number of students.
using System;
class Handshake{
  static void Main(string[] args){
    Console.WriteLine("Enter the number of students: ");
    int numberOfStudents=Convert.ToInt32(Console.ReadLine());
    int maximumHandshake=CalculateHandshakes(numberOfStudents);
    Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is: " + maximumHandshake);
  }
  static int CalculateHandshakes(int n){
    //calculating the maximum no of handshakes 
    int handshakes=(n*(n-1))/2;
    return handshakes;
  }
}