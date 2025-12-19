// 5. Suppose you have to divide 14 pens among 3 students equally. Write a program to find how many pens each student will get if the pens must be divided equally. Also, find the remaining non-distributed pens.
using System;
class PenDistribution{
  static void Main(string[] args){
    int totalpens=14;
    int students=3;
    //formula to calculate pens per student
    int pensperstudents=totalpens/students;
    //formula to calculate remaining pens
    int remainingpens=totalpens%students;
    Console.WriteLine("The Pen Per Student is " + pensperstudents + " and the remaining pent not distributed is " +remainingpens);
  }
}