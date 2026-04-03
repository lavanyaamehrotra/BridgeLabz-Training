using System;
using System.Collections.Generic;
class CircularTour{
  static int StartingPoint(int[] petrol, int[] distance, int n){
    Queue<int> q = new Queue<int>();
    int petrolLeftInTank = 0;
    int start = 0;
    int i = 0;
    while (i < n){
      petrolLeftInTank += petrol[i] - distance[i];
      q.Enqueue(i);
      if (petrolLeftInTank < 0){
        q.Clear();
        petrolLeftInTank = 0;
        start = i + 1;
      }
      i++;
    }
    // if total petrol is sufficient or not
    int total = 0;
    for (int j = 0; j < n; j++){
      total += petrol[j] - distance[j];
    }
    return (total >= 0) ? start : -1;
  }
  static void Main(){
    Console.Write("Enter number of petrol pumps: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] petrol = new int[n];
    int[] distance = new int[n];
    Console.WriteLine("Enter petrol at each pump:");
    for (int i = 0; i < n; i++){
      petrol[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Enter distance to next pump:");
    for (int i = 0; i < n; i++){
      distance[i] = Convert.ToInt32(Console.ReadLine());
    }
    int start = StartingPoint(petrol, distance, n);
    if (start == -1){
      Console.WriteLine("No circular tour");
    }else{
      Console.WriteLine("Start at petrol pump index: " + start);
    }
  }
}
