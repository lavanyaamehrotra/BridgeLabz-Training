//   Write a program that generates five 4 digit random values and then finds their average value, and their minimum and maximum value. Use Math.Random(), Math.Min(), and Math.Max().
using System;
class RandomAndAverage{
  static void Main(){
    Console.WriteLine("Generating 5 random 4-digit numbers");
    int[] numbers = Generate4DigitRandomArray(5);
    Console.WriteLine("Generated Numbers:");
    foreach (int num in numbers){
      Console.WriteLine(num);
    }
    double[] results = FindAverageMinMax(numbers);
    Console.WriteLine("Result:");
    Console.WriteLine("Average = " + results[0]);
    Console.WriteLine("Minimum = " + results[1]);
    Console.WriteLine("Maximum = " + results[2]);
  }
  // Method to generate array of 4-digit random numbers
  public static int[] Generate4DigitRandomArray(int size){
  int[] arr = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++){
    arr[i] = rand.Next(1000, 10000);
  }
  return arr;
}
// Method to find average, min and max
public static double[] FindAverageMinMax(int[] numbers){
  int min = numbers[0];
  int max = numbers[0];
  int sum = 0;
  foreach (int num in numbers){
    sum += num;
    min = Math.Min(min, num);
    max = Math.Max(max, num);
  }
  double average = (double)sum / numbers.Length;
  return new double[] { average, min, max };
  }
}
