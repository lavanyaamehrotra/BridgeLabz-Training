using System;
class StudentsScore{
  static int[] scores = new int[100];
  static int count = 0;
  //to enter the number of students
  static void EnterStudents(){
    Console.Write("Enter number of students: ");
    count = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Students data is stored successfully");
  }
  // Enter student scores
  static void Scores(){
    if (count == 0){
      Console.WriteLine("Please enter number of students.");
      return;
    }
    for (int i = 0; i < count; i++){
      Console.Write("Enter score of student " + (i + 1) + ": ");
      scores[i] = Convert.ToInt32(Console.ReadLine());
      while (scores[i] < 0){
        Console.WriteLine("scores cannot be less than 0");
        scores[i] = Convert.ToInt32(Console.ReadLine());
      }
    }
    Console.WriteLine("scores data is saved succesfully.");
  }
  //Calculate and return average
  static float Average(){
    int sum = 0;
    for (int i = 0; i < count; i++)
      sum += scores[i];
    return (float)sum / count;
  }
  // Show Average Score
  static void ShowAverage(){
    if (count == 0){
      Console.WriteLine("Enter scores first.");
    return;
    }
    float avg = Average();
    Console.WriteLine("Average Score = " + avg);
  }
  // Show Highest & Lowest Score
  static void HighestAndLowest(){
    if (count == 0){
      Console.WriteLine("Enter scores first.");
    return;
    }
    int highest = scores[0];
    int lowest = scores[0];
    for (int i = 1; i < count; i++){
      if (scores[i] > highest)
        highest = scores[i];
      if (scores[i] < lowest)
        lowest = scores[i];
    }
    Console.WriteLine("Highest Score = " + highest);
    Console.WriteLine("Lowest Score  = " + lowest);
  }
  // Show scores above average
  static void AboveAverage(){
    if (count == 0){
      Console.WriteLine("Enter scores first.");
      return;
    }
    float avg = Average();
    Console.WriteLine("Scores above average:");
    for (int i = 0; i < count; i++){
      if (scores[i] > avg)
        Console.WriteLine(scores[i]);
      }
    }
  // Main Menu 
  static void Main(){
    while (true){
      Console.WriteLine("\n-------------------Student Score Card---------------");
      Console.WriteLine("1. Enter number of students");
      Console.WriteLine("2. Enter scores");
      Console.WriteLine("3. Show Average Score");
      Console.WriteLine("4. Show Highest & Lowest Score");
      Console.WriteLine("5. Show Scores Above Average");
      Console.WriteLine("6. Exit");
      Console.Write("Choose an option: ");
      string choice = Console.ReadLine();
      if (choice == "1") EnterStudents();
      else if (choice == "2") Scores();
      else if (choice == "3") ShowAverage();
      else if (choice == "4") HighestAndLowest();
      else if (choice == "5") AboveAverage();
      else if (choice == "6"){
        Console.WriteLine("Thanku");
        break;
      }
      else
        Console.WriteLine("Invalid choic ");
    }
  }
}
