// Create a program to find the mean height of players present in a football team.
using System;
class MeanHeight{
  static void Main(string[] args){
    double[] heights=new double[11];
    double sum=0.0;
    for(int i=0;i<heights.Length;i++){
      Console.WriteLine("Enter height of player " + (i+1) + " in meters:");
      heights[i]=Convert.ToDouble(Console.ReadLine());
      sum+=heights[i];
    }
    double mean=sum/heights.Length;
    Console.WriteLine("The mean height of the football team is: " + mean + " meters");
  }
}