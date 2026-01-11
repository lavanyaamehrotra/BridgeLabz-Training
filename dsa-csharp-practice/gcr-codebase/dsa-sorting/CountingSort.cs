using System;
class CountingSort{
  // function to sort age using Counting Sort
  static void SortingAgesUsingCountingSort(int[] age){
    int n = age.Length;
    int minimumAge = 1;
    int maximumAge = 100;
    int range = maximumAge - minimumAge + 1;
    // Creating count array to store frequency of each age
    int[] count = new int[range];
    // Count how many times each age appears
    for (int i = 0; i < n; i++){
      count[age[i] - minimumAge]++;
    }
    // Modify count array to store cumulative count
    for (int i = 1; i < range; i++){
      count[i] += count[i - 1];
    }
    int[] ans = new int[n];
    for (int i = n - 1; i >= 0; i--){
      int currentAge = age[i];
      int index = count[currentAge - minimumAge] - 1;
      ans[index] = currentAge;
      count[currentAge - minimumAge]--;
    }
    for (int i = 0; i < n; i++){
      age[i] = ans[i];
    }
  }
  //Main Method
  static void Main(){
    Console.Write("Enter number of students: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] age = new int[n];
    Console.WriteLine("Enter student age:");
    for (int i = 0; i < n; i++){
      age[i] = Convert.ToInt32(Console.ReadLine());
    }
    SortingAgesUsingCountingSort(age);
    Console.WriteLine("\nSorted age:");
    for (int i = 0; i < n; i++){
      Console.Write(age[i] + " ");
    }
  }
}
