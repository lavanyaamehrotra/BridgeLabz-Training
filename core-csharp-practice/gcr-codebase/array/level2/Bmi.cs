// An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
using System;
class Bmi{
  static void Main(string[] args){
  Console.Write("Enter number of persons: ");
  int n = Convert.ToInt32(Console.ReadLine());
  double[] height = new double[n];
  double[] weight = new double[n];
  double[] bmi = new double[n];
  string[] status = new string[n];
  // Input height & weight
  for (int i = 0; i < n; i++){
    Console.WriteLine($"Person {i + 1}:");
    Console.Write("Enter height (in meters): ");
    height[i] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter weight (in kg): ");
    weight[i] = Convert.ToDouble(Console.ReadLine());
    // BMI formula
    bmi[i] = weight[i] / (height[i] * height[i]);
    // Determine weight status
    if (bmi[i] <= 18.4){
      status[i] = "Underweight";
    }else if (bmi[i] <= 24.9){
      status[i] = "Normal";
    }else if (bmi[i] <= 39.9){
      status[i] = "Overweight";
    }else{
      status[i] = "Obese";
    }
  }
    Console.WriteLine("\nHeight (m)\tWeight (kg)\tBMI\tStatus");
    for (int i = 0; i < n; i++){
      Console.WriteLine($"{height[i]:0.00}\t\t{weight[i]:0.0}\t\t{bmi[i]:0.00}\t{status[i]}");
    }
  }
}
