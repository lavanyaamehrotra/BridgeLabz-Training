//2. Sam’s mark in Maths is 94, Physics is 95, and Chemistry is 96 out of 100. Find the average percent mark in PCM
using System;
class SamsMarks{
  static void Main(string[] args){
    int Maths=94;
    int Physics=95;
    int Chemistry=96;
    //formula to calculate average
    double average=(Maths+Physics+Chemistry)/3.0;
    Console.WriteLine("Sam's average mark in PCM is " + average);
  }
}