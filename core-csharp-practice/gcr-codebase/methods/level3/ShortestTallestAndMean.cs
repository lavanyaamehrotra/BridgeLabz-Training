// Create a program to find the shortest, tallest, and mean height of players present in a football team.
using System;
class ShortestTallestAndMean{
  static void Main(string[] args){
    int[] heights = new int[11];
    Console.WriteLine("Randomly generating heights for 11 football players");
    Random rand = new Random();
    // generate random heights between 150 and 250
    for (int i = 0; i < heights.Length; i++){
      heights[i] = rand.Next(150, 251);
      Console.WriteLine("Player " + (i + 1) + " Height = " + heights[i]);
    }
    int sum = FindSum(heights);
    double mean = FindMean(heights);
    int shortest = FindShortest(heights);
    int tallest = FindTallest(heights);
    Console.WriteLine("Sum of Heights = " + sum);
    Console.WriteLine("Mean Height = " + mean);
    Console.WriteLine("Shortest Height = " + shortest);
    Console.WriteLine("Tallest Height = " + tallest);
  }
  // Method to find sum of all elements
  public static int FindSum(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
      sum += arr[i];
    }
    return sum;
  }
  // Method to find mean height
  public static double FindMean(int[] arr){
    int sum = FindSum(arr);
    return (double)sum / arr.Length;
  }
  // Method to find shortest height
  public static int FindShortest(int[] arr){
    int min = arr[0];
      for (int i = 1; i < arr.Length; i++){
        if (arr[i] < min){
          min = arr[i];
        }
      }
      return min;
    }
  // Method to find tallest height
  public static int FindTallest(int[] arr){
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++){
      if (arr[i] > max){
        max = arr[i];
      }
    }
  return max;
  }
}
