// 16. Create a program to find the maximum number of handshakes among N number of students.
using System;
class NumberOfHandshake{
  static void Main(string[] args){
    Console.WriteLine("Enter the number of students:");
    int numberOfStudents=Convert.ToInt32(Console.ReadLine());
    //Formula to calculate number of handshakes
    int numberOfHandshake=(numberOfStudents*(numberOfStudents-1))/2;
    Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is: " + numberOfHandshake);
  }
}