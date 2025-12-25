//An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
using System;
class Bmi{
  static void Main(){
    int totalPersons = 10;
    double[,] data = new double[totalPersons, 3];
    for (int i = 0; i < totalPersons; i++){
      Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
      data[i, 0] = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
      data[i, 1] = Convert.ToDouble(Console.ReadLine());
    }
    // Calculate BMI
    CalculateBMI(data, totalPersons);
    string[] status = DetermineBMIStatus(data, totalPersons);
    Console.WriteLine("\nPerson\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
    for (int i = 0; i < totalPersons; i++){
      Console.WriteLine((i + 1) + "\t" + data[i, 0] + "\t\t" + data[i, 1] + "\t\t" + Math.Round(data[i, 2], 2) + "\t\t" + status[i]);
    }
  }
  // Method to calculate BMI and populate the 3rd column of the array
  public static void CalculateBMI(double[,] data, int totalPersons){
  for (int i = 0; i < totalPersons; i++){
    double weight = data[i, 0]; 
    double heightCm = data[i, 1];
    double heightM = heightCm / 100;
    double bmi = weight / (heightM * heightM);
    data[i, 2] = bmi; 
  }
}
// Method to determine BMI status for each person
  public static string[] DetermineBMIStatus(double[,] data, int totalPersons){
    string[] status = new string[totalPersons];
      for (int i = 0; i < totalPersons; i++){
        double bmi = data[i, 2];
        if (bmi < 18.5)
          status[i] = "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9)
          status[i] = "Normal weight";
        else if (bmi >= 25 && bmi < 29.9)
          status[i] = "Overweight";
        else
          status[i] = "Obese";
      }
    return status;
  }
}
