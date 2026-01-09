using System;
class Program{
  static void Main(){
    UserProfile user = new UserProfile("Alex", 22, 70);
    Workout cardio = new CardioWorkout(30, user, 8);
    Workout strength = new StrengthWorkout(40, user, 4);cardio.StartWorkout();
    Console.WriteLine($"Calories burned (Cardio): {cardio.CaloriesBurned():F2}");
    cardio.EndWorkout();
    Console.WriteLine();
    strength.StartWorkout();
    Console.WriteLine($"Calories burned (Strength): {strength.CaloriesBurned():F2}");
    strength.EndWorkout();
  }
}
