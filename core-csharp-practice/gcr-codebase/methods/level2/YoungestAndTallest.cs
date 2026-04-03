//  Create a program to find the youngest friends among 3 Amar, Akbar and Anthony based on their ages and tallest among the friends based on their heights and display it
using System;
class YoungestAndTallest{
 static void Main(){
  string[] names = { "Amar", "Akbar", "Anthony" };
  int[] ages = new int[3];
  double[] heights = new double[3];        
  for (int i = 0; i < 3; i++){
    Console.Write("Enter age of " + names[i] + ": ");
    ages[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter height of " + names[i] + " (in cm): ");
    heights[i] = Convert.ToDouble(Console.ReadLine());
  }
  // Find youngest and tallest
  string youngest = FindYoungest(names, ages);
  string tallest = FindTallest(names, heights);
  Console.WriteLine("The youngest friend is: " + youngest);
  Console.WriteLine("The tallest friend is: " + tallest);
  }
    // Method to find the youngest friend
    public static string FindYoungest(string[] names, int[] ages){
      int minimumAge = ages[0];
      string youngest = names[0];
      for (int i = 1; i < ages.Length; i++){
        if (ages[i] < minimumAge){
          minimumAge = ages[i];
          youngest = names[i];
        }
      }
      return youngest;
    }
    // Method to find the tallest friend
    public static string FindTallest(string[] names, double[] heights){
    double maximumHeight = heights[0];
    string tallest = names[0];
    for (int i = 1; i < heights.Length; i++){
      if (heights[i] > maximumHeight){
        maximumHeight = heights[i];
        tallest = names[i];
      }
    }
    return tallest;
  }
}
